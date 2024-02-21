using AutoMapper;
using Billetera.Models.Mapper;

namespace Billetera.View
{
    public partial class FrmBase : Form
    {
        protected readonly IMapper _mapper;
        public FrmBase()
        {
            InitializeComponent();
            _mapper = AutoMapperConfig.Initialize();
        }


        public static DialogResult ShowMessageInfo(string message, string caption = "Información")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowMessageWarning(string message, string caption = "Warning")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowMessageError(string message, string caption = "Error")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
