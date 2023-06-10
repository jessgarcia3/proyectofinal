namespace ProyectoFinal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void listaEnlazadaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple formulariolistasimple = new frmListaSimple();
            formulariolistasimple.MdiParent = this;
            formulariolistasimple.Show();
        }

        private void listaEnlazadaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazadaDoble formulariolistadoble = new frmListaEnlazadaDoble();
            formulariolistadoble.MdiParent = this;
            formulariolistadoble.Show();
        }

        private void listaEnlazadaCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCircularSimple formulariolistacircular = new frmListaCircularSimple();
            formulariolistacircular.MdiParent = this;
            formulariolistacircular.Show();
        }
    }
}