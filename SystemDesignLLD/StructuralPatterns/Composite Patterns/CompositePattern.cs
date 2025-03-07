using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.StructuralPatterns.Composite_Patterns
{
    public class CompositePattern
    {
        public void MainMethod()
        {
            FileSystemComponent file1 = new File("file1.txt");
            FileSystemComponent file2 = new File("file2.txt");

            Folder folder = new Folder("My Document");
            folder.addComponent(file1);
            folder.addComponent(file2);


            // created sub folder 
            Folder subFolder = new Folder("Sub Folder");
            FileSystemComponent file3 = new File("file3.cs");
            subFolder.addComponent(file3);
            folder.addComponent(subFolder);

            folder.showDetails();
        }
    }

    public interface FileSystemComponent
    {
        void showDetails();
    }

    public class File : FileSystemComponent
    {
        private string name;
        public File(string name)
        {
            this.name = name;
        }
        public void showDetails()
        {
            Console.WriteLine("File : " + name);
        }
    }


    public class Folder: FileSystemComponent
    {
        private string name;
        private List<FileSystemComponent> components = new List<FileSystemComponent>();
        public Folder(string name)
        {
            this.name = name;
        }

        public void addComponent(FileSystemComponent component)
        {
            components.Add(component);
        }

        public void showDetails()
        {
            Console.WriteLine("Folder: " + name);
            foreach (FileSystemComponent component in components)
            {
                component.showDetails();
            }
        }
    }
}
