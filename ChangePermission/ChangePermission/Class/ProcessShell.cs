using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ChangePermission.Class
{
    public class ProcessShell
    {
        public object StreamRader { get; private set; }

        //public void obtenerUsuarios()
        //{
        //     Process proc = Process.Start(@"C:\\Users\\Camilo Gomez\\Desktop\\usuarios3.bat");

        //    this.pintarUsuarios();

        //}

        
        public List<string> pintarUsuarios()
        {
            List<string> usuarios = new List<string>(); 
             try
            {
                //Se indica le ruta donde se encuentra alojado el archivo txt que va hacer leido 
                using (StreamReader sr = new StreamReader("C:\\Users\\Camilo Gomez\\Desktop\\usuarios20.txt", false))
                {
              
                    string line;
                    while ((line = sr.ReadLine()) != null) 
                    {
                        usuarios.Add(line);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se puede leer");
            }

            return usuarios;
            
        }
        
    }
}
