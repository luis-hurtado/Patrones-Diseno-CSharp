using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Ejercicio
{
    internal class Demo
    {
        static public void Ejecutar()
        {
            Folder folderRaiz = new Folder("Raiz");
            Folder folder1 = new Folder("Folder1");
            Folder folder2 = new Folder("Folder2");
            Folder folder3 = new Folder("Folder3");
            Archivo archivo1 = new Archivo("Documento1.docx");
            Archivo archivo2 = new Archivo("Documento2.pdf");
            Archivo archivo3 = new Archivo("Documento3.xlsx");
            Archivo archivo4 = new Archivo("Documento4.pptx");

            folderRaiz.AgregarContenido(folder1);
            folderRaiz.AgregarContenido(folder2);
            folderRaiz.AgregarContenido(archivo1);
            folder2.AgregarContenido(folder3);
            folder2.AgregarContenido(archivo2);
            folder3.AgregarContenido(archivo3);
            folder3.AgregarContenido(archivo4);

            folder3.Mover("D:");
            folderRaiz.Eliminar();

        }
    }
}
