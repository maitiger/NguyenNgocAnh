using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace baithi.Entity
{
    class file
    {
        private string _content;

        public string content { get => _content; set => _content = value; }

        internal Task<StorageFile> PickSingleFileAsync()
        {
            throw new NotImplementedException();
        }
    }
}
