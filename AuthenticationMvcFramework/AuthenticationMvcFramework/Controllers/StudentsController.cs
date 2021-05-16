using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using AuthenticationMvcFramework;
using GemBox.Spreadsheet;
using Magnum.FileSystem;

namespace AuthenticationMvcFramework.Controllers
{    [Authorize]
    public class StudentsController : Controller
    {
        private StudentCapabilityDBEntities db = new StudentCapabilityDBEntities();
        //public static void WriteExcel(List<Student> students)
        //    {
        //    SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

        //    var workbook = new ExcelFile();

        //    var worksheet = workbook.Worksheets.Add("student.txt");

        //    worksheet.Cells[0, 0].Value = "Id";
        //    worksheet.Cells[0, 1].Value = "Name";
        //    worksheet.Cells[0, 2].Value = "Mobile";
        //    worksheet.Cells[0, 3].Value = "Email";
        //    worksheet.Cells[0, 4].Value = "Grade";
        //    worksheet.Cells[0, 5].Value = "Fee";



        //    int i = 1;
        //    foreach(Student obj in students)
        //        {
        //        int j = 0;
        //        worksheet.Cells[i, j].Value = obj.Id;
        //        j++;
        //        worksheet.Cells[i, j].Value = obj.Name;
        //        j++;
        //        worksheet.Cells[i, j].Value = obj.Mobile;
        //        j++;
        //        worksheet.Cells[i, j].Value = obj.Email;
        //        j++;
        //        worksheet.Cells[i, j].Value = obj.Grade;
        //        j++;
        //        worksheet.Cells[i, j].Value = obj.Fee;
        //        j++;
        //        i++;
        //        }

        //    workbook.Save("student.txt");

        //    }
        public ActionResult ExportToExcel()
            {
            // Step 1 - get the data from database
            var data = db.Students.ToList();

            // instantiate the GridView control from System.Web.UI.WebControls namespace
            // set the data source
            GridView gridview = new GridView();
            gridview.DataSource = data;
            gridview.DataBind();

            // Clear all the content from the current response
            Response.ClearContent();
            Response.Buffer = true;
            // set the header
            Response.AddHeader("content-disposition", "attachment;FileName = StudentDetails.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            // create HtmlTextWriter object with StringWriter
            using(StringWriter sw = new StringWriter())
                {
                using(HtmlTextWriter htw = new HtmlTextWriter(sw))
                    {
                    // render the GridView to the HtmlTextWriter
                    gridview.RenderControl(htw);
                    // Output the GridView content saved into StringWriter
                    Response.Output.Write(sw.ToString());
                    Response.Flush();
                    Response.End();
                    }
                }
            return View();
            }

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ExportToExcel();

            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Mobile,Email,Grade,Fee")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Mobile,Email,Grade,Fee")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
