using SPA.Domain.Entity;

namespace SPA
{
    public partial class Form1 : Form
    {
        private readonly SPA.Domain.ApplicationDbContext _context;
        public Form1()
        {
            InitializeComponent();
            this._context = new SPA.Domain.ApplicationDbContext();
            this._context.Database.EnsureCreated();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._context.Dispose();
        }
    }
}
