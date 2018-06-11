using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace DocsSenderApp.Models
{
    public class File
    {
        public File()
        {
            this.FileId = Guid.NewGuid().ToString();
            Employees = new List<Employee>();
        }
        public string FileId { get; set; }
        public byte[] SourceFile { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] PreviewImage { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
