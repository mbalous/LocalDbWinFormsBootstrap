using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

using LocalDbWinFormsBootstrap.Entities;

namespace LocalDbWinFormsBootstrap
{
    public partial class MainForm : Form
    {
        private readonly SampleDbContext _dbContext;

        public MainForm()
        {
            InitializeComponent();
            // Create context instance
            this._dbContext = new SampleDbContext("sampleDb");
            // Load set
            this._dbContext.Set<Person>().Load();
        }
    }
}