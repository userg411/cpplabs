using System;

namespace Customer.Utils{
    class FileLogger{
        public void Handle(string error){
            System.IO.File.WriteAllText("err.txt",error);
        }
    }
}