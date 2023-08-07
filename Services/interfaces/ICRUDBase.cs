using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadedFileDownload.Services.interfaces
{
    internal interface ICRUDBase
    {
        public void Create(string location);
        public void Delete(string deletePath);
        public void DeleteAll(string AllInPath);
        public List<string> GetAll(string AllInPath);

    }
}
