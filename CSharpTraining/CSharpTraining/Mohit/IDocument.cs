using System;

namespace CSharpTraining.Mohit
{
    public interface IDocument
    {
        // Method declaration
        void Print();

        // Property declaration
        string Title { get; set; }

        // Event declaration
        event EventHandler<DocumentEventArgs> DocumentSaved;

        event EventHandler<ButtonEventArgs> ButtonClicked;
    }

    public class ButtonEventArgs : EventArgs
    {
        public string buttonMessage { get; set; }
        public ButtonEventArgs(string message)
        {

            buttonMessage = message;
        }
    }


    // Custom event arguments class for the DocumentSaved event
    public class DocumentEventArgs : EventArgs
    {
        public string message { get; set; }

        public DocumentEventArgs(string sms)
        {
            message = sms;
        }
    }

    public class Document : IDocument
    {
        private string _title;

        // property implementation
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        //method implementation
        public void Print()
        {
            Console.WriteLine($"Printing document: {Title}");
        }

        //event implementation
        public event EventHandler<DocumentEventArgs> DocumentSaved;


        // Method to simulate saving the document and raising the event
        public void SaveDocument()
        {
            // Perform document saving logic...

            // Raise the DocumentSaved event
            OnDocumentSaved("Document saved successfully.");
        }
        protected virtual void OnDocumentSaved(string message)
        {
            DocumentSaved?.Invoke(this, new DocumentEventArgs(message));
        }

        public event EventHandler<ButtonEventArgs> ButtonClicked;
        public void ButtonClick()
        {
            OnButtonClicked("Button Clicked successfully");
        }
        protected virtual void OnButtonClicked(string message)
        {
            ButtonClicked?.Invoke(this, new ButtonEventArgs(message));
        }

    }

    class Program
    {
        static void Main()
        {
            // Create an instance of Document
            Document document = new Document();
            document.Title = "Sample Document";

            // Call the Print method
            document.Print();

            // Subscribe to the DocumentSaved event
            document.DocumentSaved += DocumentSavedHandler;

            // Save the document (and trigger the event)
            document.SaveDocument();

            document.ButtonClicked += ButtonClickedHandler;
            document.ButtonClick();
        }

        private static void ButtonClickedHandler(object sender, ButtonEventArgs e)
        {
            Console.WriteLine($"Button Clicked successfully: {e.buttonMessage}");
        }

        // Event handler for DocumentSaved event
        private static void DocumentSavedHandler(object sender, DocumentEventArgs e)
        {
            Console.WriteLine($"Document saved event received: {e.message}");
        }
    }

}