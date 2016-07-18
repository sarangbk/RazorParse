using System;
using System.Text;
using System.Windows.Forms;
using System.Web.Razor.Text;
using System.Web.Razor.Parser;
using System.IO;

namespace RazorParse
{
    public partial class frmMainForm : Form
    {
        const string templateFilePath = @"..\..\Templates\some-razor-template.chtml";
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            rtbSourceRazor.LoadFile(templateFilePath, RichTextBoxStreamType.PlainText);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            System.Web.Razor.Parser.CSharpLanguageCharacteristics cSharpParser = CSharpLanguageCharacteristics.Instance;
            StreamReader stReader = new StreamReader(templateFilePath, true);
            System.Web.Razor.Text.BufferingTextReader reader = new BufferingTextReader(stReader);
            SeekableTextReader seekableTextreader = new SeekableTextReader(reader);
            var tokenizer = cSharpParser.CreateTokenizer(seekableTextreader);
            while (true)
            {
                var symbol = tokenizer.NextSymbol();
                if (symbol == null)
                    break;
                if (symbol.Type == System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType.WhiteSpace)
                    continue;
                sb.Append(string.Format("{0}:{1}:{2}\n", symbol.Type, symbol.Keyword, symbol.Content));
                //sb.Append(tokenizer.NextSymbol.Text);
            }
            rtbParseResult.Text = sb.ToString();
        }
    }
}
