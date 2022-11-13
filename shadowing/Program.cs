using System;

namespace shadowing
{
    class BaseClass
         {

        static BaseClass()
        {
            Console.WriteLine("Parent static constructor");
        }
        public BaseClass()
        {
            Console.WriteLine("Parent");
        }
        public virtual void parentMethod()    //overridable
        {
            Console.WriteLine("parentMethod BaseClass method called in overriding");
        }
        public void loadBaseMethod()
            {
            Console.WriteLine("loadBaseMethod BaseClass method called in shadowing");
            }
        }
    class DerivedClass:BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("child constructor");
        }
        public override void parentMethod()  //overriding
        {
            Console.WriteLine("parent Method DerivedClass method called in overriding");
        }
        public new void  loadBaseMethod()
        {
            Console.WriteLine("loadBase Method child class method called in shadowing");
        }
        static void Main(string[] args)
        {
            DerivedClass b1 = new DerivedClass(); //child class method called in hiding
            b1.loadBaseMethod(); //In shadowing if child class object created then always call child class method
            //-------------------------------------------------------------------------------//
           BaseClass b2 = new BaseClass();//In shadowing if parent class object created then always call parent class method
           b2.loadBaseMethod();//In shadowing if parent class object created then always call parent class method
            //-------------------------------------------------------------------------------------//
           BaseClass b3 = new DerivedClass();//In shadowing if child class object created and hold by the parent class then always call parent class method
           b3.loadBaseMethod();// always call parent class method
            //------------------------------------------------------------------------------------//
            //DerivedClass d1 = new BaseClass(); //error because by using child class reference never create parent class object
            //------------------------------------------------------------------------------------//
           BaseClass c1 = new BaseClass();  //if parent class object and parent class reference then parent class method called in overrriding
           c1.parentMethod(); //it will always call parent class method
            //-----------------------------------------------------------------------------------//
           BaseClass d = new DerivedClass(); //derived class method called when parent reference 
            //                                   and child class object create
           d.parentMethod();//always called child class method in overriding
            Console.ReadLine();
        }
    }
}
