using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Mohit
{
    internal class AccessModifiers
    {
        // "PUBLIC" Use for APIs and members that need to be accessed from anywhere
        public class ApiClient
        {
            public void Connect() { }
        }


        // "PRIVATE" to hide implementation details and protect members from being accessed outside the class
        public class DatabseConnection
        {
            private string connectionString;
            private void OpenConnection()
            {
                //any implementation but we don't want to expose it
            }

            // public method that we will use in further implementation
            public void Initialise(string conneString)
            {
                connectionString = conneString;
                OpenConnection();
            }
        }


        /* "PROTECTED" members to allow derived classes to access and override base class functionality while keeping
        these members hidden from the other classes. This is used in polymorphism and inheritance*/
        public class Animal
        {
            protected static void Breathe()
            {
                Console.WriteLine("Breathing");
            }
        }

        // try to remove the inheriting of animal class
        public class Dog : Animal
        {
            public void method()
            {
                Breathe();
            }
        }


        // "INTERNAL" members will be accessible inside the same assembly. Like you are defining  internal logic for a single module.
        internal class Logger
        {
            // this method will be accessible within the same assembly means inside a (.exe or .dll) file.
            internal void LogMessage()
            {

            }
        }

        /* "PROTECTED INTERNAL" members to make them accessible within the same assembly and in derived classes. This is useful when
        you want to provide extended functionality to derived classes (can be other assembly also) while keeping it internal to the assembly. */
        public class BaseClass
        {
            // Protected internal method accessible within the same assembly and derived classes
            protected internal void DoSomething()
            {
                Console.WriteLine("Doing something");
            }
        }

        // try to remove the inherited BaseClass once
        public class DerivedClass : BaseClass
        {
            public void Execute()
            {
                // Accessing protected internal method
                DoSomething();

                // we are able to call the LogMessage method here also as they are in the same assembly
                Logger logger = new Logger();
                logger.LogMessage();
            }
        }


        /* "PRIVATE PROTECTED" members to make them accessible within the same class and derived classes within the same assembly
         This provides a higher level of encapsulation than protected internal.*/
        public class BaseClass1
        {
            // Private protected method accessible within the same class and derived classes in the same assembly
            private protected void RestrictedMethod()
            {
                Console.WriteLine("Restricted method");
            }
        }

        public class DerivedClass1 : BaseClass1
        {
            public void AccessRestrictedMethod()
            {
                // Accessing private protected method
                RestrictedMethod();
            }
        }

        public class FinalClass : Animal
        {
            static void Main(string[] args)
            {
                // we can access the public method
                ApiClient apiClient = new ApiClient();
                apiClient.Connect();

                // we can't access the private method, but a refernece to public method which is running private method can do
                DatabseConnection databseConnection = new DatabseConnection();
                databseConnection.Initialise("Connection string");

                // We can only call protected methods when the class is inherited
                Breathe();


                // As Logger class is a Internal class and it is in the same assembly, so we can call it's members
                Logger logger = new Logger();
                logger.LogMessage();
            }
        }
    }
}