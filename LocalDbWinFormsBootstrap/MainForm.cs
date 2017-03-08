using LocalDbWinFormsBootstrap.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDbWinFormsBootstrap
{
    public partial class MainForm : Form
    {
        private readonly SampleDbContext _dbContext;

        public MainForm()
        {
            InitializeComponent();
            // Create context instance
            _dbContext = new SampleDbContext("sampleDb");
            // Load set
            _dbContext.Set<Person>().Load();
            List<Person> y = _dbContext.Set<Person>().ToList();
            foreach (var item in y)
            {
                Debug.WriteLine(item.Id);
            }
        }
    }
}