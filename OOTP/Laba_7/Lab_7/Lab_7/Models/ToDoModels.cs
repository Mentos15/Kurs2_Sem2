using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{

    public class ToDoModels 
    {
        private bool _status;
        private string _text;
        private string _category;

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string Category{get;set;}
        
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        } 
        
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        
        public DateTime? EndDate { get; set; }
        public ToDoModels()
        {

        }

        public ToDoModels(string category, string text, DateTime? date)
        {
            Category = category;
            Text = text;
            EndDate = date;
            
        }

    }
    class TaskList
    {
        public static BindingList<ToDoModels> taskList = new BindingList<ToDoModels>();
        public static BindingList<ToDoModels> list = new BindingList<ToDoModels>();
    }
}
