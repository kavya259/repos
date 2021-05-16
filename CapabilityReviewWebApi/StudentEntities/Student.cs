using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEntities
    {
    public class Student
        {
        /// <summary>
        /// student entities with id as primary key and autoincremented
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
            {
            get; set;
            }
        public string? Name
            {
            get; set;
            }
        public string ?Address
            {
            get; set;
            }
        }
    }
