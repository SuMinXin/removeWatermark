using GroupDocs.Watermark;
using GroupDocs.Watermark.Search;
using GroupDocs.Watermark.Search.SearchCriteria;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace rmWatermark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ChoseFile_Click(object sender, EventArgs e)
        {
            // Folder
            // FolderBrowserDialog folder = new FolderBrowserDialog();
            // folder.ShowDialog();
            // txtPath.Text = folder.SelectedPath;
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            txtPath.Text = file.FileName;
        }

        private void btn_Trans_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtPath.Text)) {
                MessageBox.Show("無法找到檔案");
                return;
            }
            /*
            using (Watermarker watermarker = new Watermarker(txtPath.Text))
            {
                TextFormattingSearchCriteria criteria = new TextFormattingSearchCriteria();
                criteria.ForegroundColorRange = new ColorRange();
                criteria.ForegroundColorRange.MinHue = -5;
                criteria.ForegroundColorRange.MaxHue = 10;
                criteria.ForegroundColorRange.MinBrightness = 0.01f;
                criteria.ForegroundColorRange.MaxBrightness = 0.99f;
                criteria.BackgroundColorRange = new ColorRange();
                criteria.BackgroundColorRange.IsEmpty = true;
                criteria.FontName = "Arial";
                criteria.MinFontSize = 19;
                criteria.MaxFontSize = 42;
                criteria.FontBold = true;

                PossibleWatermarkCollection watermarks = watermarker.Search(criteria);
                if (watermarks.Count > 0) {
                    watermarks.Clear();
                }
                
                string fileName = Path.GetFileNameWithoutExtension(txtPath.Text);
                string outFile = txtPath.Text.Replace(fileName, fileName + "_RM");
                watermarker.Save(outFile);
            }
            */
            /*string workingFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string startFile = txtPath.Text;
            // string watermarkedFile = Path.Combine(workingFolder, "Watermarked.pdf");
            string unwatermarkedFile = Path.Combine(workingFolder, "Un-watermarked.pdf");
            string watermarkText = "Prepared for Flex 03-25-2021";

            // //SECTION 1
            // //Create a 5 page PDF, nothing special here
            // using (FileStream fs = new FileStream(startFile, FileMode.Create, FileAccess.Write, FileShare.None))
            // {
            //     using (Document doc = new Document(PageSize.LETTER))
            //     {
            //         using (PdfWriter witier = PdfWriter.GetInstance(doc, fs))
            //         {
            //             doc.Open();
            // 
            //             for (int i = 1; i <= 5; i++)
            //             {
            //                 doc.NewPage();
            //                 doc.Add(new Paragraph(String.Format("This is page {0}", i)));
            //             }
            // 
            //             doc.Close();
            //         }
            //     }
            // }

            // //SECTION 2
            // //Create our watermark on a separate layer. The only different here is that we are adding the watermark to a PdfLayer which is an OCG or Optional Content Group
            // PdfReader reader1 = new PdfReader(startFile);
            // using (FileStream fs = new FileStream(watermarkedFile, FileMode.Create, FileAccess.Write, FileShare.None))
            // {
            //     using (PdfStamper stamper = new PdfStamper(reader1, fs))
            //     {
            //         int pageCount1 = reader1.NumberOfPages;
            //         //Create a new layer
            //         PdfLayer layer = new PdfLayer("WatermarkLayer", stamper.Writer);
            //         for (int i = 1; i <= pageCount1; i++)
            //         {
            //             iTextSharp.text.Rectangle rect = reader1.GetPageSize(i);
            //             //Get the ContentByte object
            //             PdfContentByte cb = stamper.GetUnderContent(i);
            //             //Tell the CB that the next commands should be "bound" to this new layer
            //             cb.BeginLayer(layer);
            //             cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 50);
            //             PdfGState gState = new PdfGState();
            //             gState.FillOpacity = 0.25f;
            //             cb.SetGState(gState);
            //             cb.SetColorFill(BaseColor.BLACK);
            //             cb.BeginText();
            //             cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, watermarkText, rect.Width / 2, rect.Height / 2, 45f);
            //             cb.EndText();
            //             //"Close" the layer
            //             cb.EndLayer();
            //         }
            //     }
            // }

            //SECTION 3
            //Remove the layer created above
            //First we bind a reader to the watermarked file, then strip out a bunch of things, and finally use a simple stamper to write out the edited reader
            PdfReader reader2 = new PdfReader(startFile);

            //NOTE, This will destroy all layers in the document, only use if you don't have additional layers
            //Remove the OCG group completely from the document.
            //reader2.Catalog.Remove(PdfName.OCPROPERTIES);

            //Clean up the reader, optional
            reader2.RemoveUnusedObjects();

            //Placeholder variables
            PRStream stream;
            String content;
            PdfDictionary page;
            PdfArray contentarray;

            //Get the page count
            int pageCount2 = reader2.NumberOfPages;
            //Loop through each page
            for (int i = 1; i <= pageCount2; i++)
            {
                //Get the page
                page = reader2.GetPageN(i);
                //Get the raw content
                contentarray = page.GetAsArray(PdfName.CONTENTS);
                if (contentarray != null)
                {
                    //Loop through content
                    for (int j = 0; j < contentarray.Size; j++)
                    {
                        //Get the raw byte stream
                        stream = (PRStream)contentarray.GetAsStream(j);
                        //Convert to a string. NOTE, you might need a different encoding here
                        content = System.Text.Encoding.ASCII.GetString(PdfReader.GetStreamBytes(stream));
                        //Look for the OCG token in the stream as well as our watermarked text
                        if (content.IndexOf("/OC") >= 0 && content.IndexOf(watermarkText) >= 0)
                        {
                            //Remove it by giving it zero length and zero data
                            stream.Put(PdfName.LENGTH, new PdfNumber(0));
                            stream.SetData(new byte[0]);
                        }
                    }
                }
            }

            //Write the content out
            using (FileStream fs = new FileStream(unwatermarkedFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (PdfStamper stamper = new PdfStamper(reader2, fs))
                {

                }
            }
            this.Close();
            */


            
            using (Watermarker watermarker = new Watermarker(txtPath.Text))
            {
                PossibleWatermarkCollection possibleWatermarks = watermarker.Search();
                // Remove watermark at the specified index from the document.
                possibleWatermarks.RemoveAt(0);
                // Remove possible watermarks from the document.
                possibleWatermarks.Remove(possibleWatermarks[0]);
                string fileName = Path.GetFileNameWithoutExtension(txtPath.Text);
                string outFile = txtPath.Text.Replace(fileName, fileName + "_RM");
                watermarker.Save(outFile);
            }
            
            MessageBox.Show("轉檔結束");
        }
    }
}
