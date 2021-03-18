using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Style_Editor
{
    public partial class mainForm : Form
    {
        //All the control declarations 
        private TextBox author = new TextBox();
        private TextBox bookTitle = new TextBox();
        private TextBox bookSection = new TextBox();
        private TextBox bookPublisher = new TextBox();
        private TextBox publishedYear = new TextBox();
        private TextBox bookPages = new TextBox();
        private TextBox printJournalIssue = new TextBox();
        //Website
        private TextBox websiteUrl = new TextBox();
        private TextBox websiteCompany = new TextBox();

        //The citation that will be built for output
        string citation = "";

        public mainForm()
        {
            InitializeComponent();
        }

        private void styleListBox_SelectedIndexChanged(object sender, EventArgs e)

        {
            //These are the text boxes that will populate out panel (citationInformationPanel) when item selected from listbox
            switch (styleListBox.SelectedIndex)
            {

                case 0:
                    //APA book
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Book Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(publishedYear);
                    break;
                case 1:
                    //APA Chapter in an edited book
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Book Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Section
                    bookSection.Width = 150;
                    bookSection.Text = "Book Chapter";
                    bookSection.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(bookPages);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(publishedYear);
                    break;
                case 2:
                    // APA Print Journal
                    citationInformationPanel.Controls.Clear();
                    //Journal Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Journal Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Article Title
                    bookSection.Width = 150;
                    bookSection.Text = "Article Title";
                    bookSection.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(author);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Date";
                    publishedYear.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(bookPages);
                    break;
                case 3:
                    //APA Electronic Journal
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Journal Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Article Title
                    bookSection.Width = 150;
                    bookSection.Text = "Article Title";
                    bookSection.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(author);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(bookPages);
                    //Website URL
                    websiteUrl.Width = 150;
                    websiteUrl.Text = "Book Pages";
                    websiteUrl.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(websiteUrl);
                    break;
                case 4:
                    //APA Website
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Date";
                    publishedYear.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Company
                    websiteCompany.Width = 150;
                    websiteCompany.Text = "Website Company";
                    websiteCompany.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(websiteCompany);
                    //Website URL
                    websiteUrl.Width = 150;
                    websiteUrl.Text = "Website URL";
                    websiteUrl.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(websiteUrl);
                    break;
                case 5:
                    //MLA Book
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Book Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(publishedYear);
                    break;
                case 6:
                    //eBook
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Book Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Section
                    bookSection.Width = 150;
                    bookSection.Text = "Book Chapter";
                    bookSection.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Website URL
                    websiteUrl.Width = 150;
                    websiteUrl.Text = "Ebook URL";
                    websiteUrl.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(websiteUrl);
                    break;
                case 7:
                    // APA Print Journal
                    citationInformationPanel.Controls.Clear();
                    //Journal Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Journal Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Article Title
                    bookSection.Width = 150;
                    bookSection.Text = "Article Title";
                    bookSection.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(author);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Date";
                    publishedYear.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(bookPages);
                    break;
                case 8:
                    //APA Electronic Journal
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Journal Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Article Title
                    bookSection.Width = 150;
                    bookSection.Text = "Article Title";
                    bookSection.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(author);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(bookPages);
                    //Website URL
                    websiteUrl.Width = 150;
                    websiteUrl.Text = "Book Pages";
                    websiteUrl.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(websiteUrl);
                    break;
                case 9:
                    //Encyclopedia Entry
                    // APA Print Journal
                    citationInformationPanel.Controls.Clear();
                    //Journal Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Encyclopedia Name";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Article Title
                    bookSection.Width = 150;
                    bookSection.Text = "Article Title";
                    bookSection.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Edited By (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(author);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Published Date";
                    publishedYear.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(bookPages);
                    break;
                case 10:
                    //Govenment Publication
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Government Agency whom Authored";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Section
                    bookSection.Width = 150;
                    bookSection.Text = "Country";
                    bookSection.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(bookPages);
                    break;

                case 11:
                    //Interview
                    citationInformationPanel.Controls.Clear();
                    //Book Author
                    author.Width = 150;
                    author.Text = "Person Interviewed";
                    author.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(author);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Date of Interview (Day Month, Year";
                    publishedYear.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(publishedYear);
                    break;

                case 12:
                    //Film / Dvd
                    citationInformationPanel.Controls.Clear();
                    //Film Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Film Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Director
                    author.Width = 150;
                    author.Text = "Director";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Actors
                    bookSection.Width = 150;
                    bookSection.Text = "Actors";
                    bookSection.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Studio that published
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Studio";
                    bookPublisher.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(publishedYear);
                    break;
                case 13:
                    //Page on website with no author 
                    citationInformationPanel.Controls.Clear();
                    //Article Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Article Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Company
                    websiteCompany.Width = 150;
                    websiteCompany.Text = "Company";
                    websiteCompany.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(websiteCompany);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Date Published";
                    publishedYear.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Website URL
                    websiteUrl.Width = 150;
                    websiteUrl.Text = "Website URL";
                    websiteUrl.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(websiteUrl);
                    break;
                case 14:
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Book Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Section
                    bookSection.Width = 150;
                    bookSection.Text = "Book Section (if applicable)";
                    bookSection.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(bookPages);
                    break;
                case 15:
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Book Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Section
                    bookSection.Width = 150;
                    bookSection.Text = "Book Section (if applicable)";
                    bookSection.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(bookPages);
                    break;
                case 16:
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Book Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Section
                    bookSection.Width = 150;
                    bookSection.Text = "Book Section (if applicable)";
                    bookSection.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher (Location : Publisher)";
                    bookPublisher.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Book Pages";
                    bookPages.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(bookPages);
                    break;
                case 17:
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Book Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Section
                    bookSection.Width = 150;
                    bookSection.Text = "Book Section (if applicable)";
                    bookSection.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Issue";
                    bookPages.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(bookPages);
                    break;
                case 18:
                    citationInformationPanel.Controls.Clear();
                    //Book Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Book Title";
                    bookTitle.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Author
                    author.Width = 150;
                    author.Text = "Author (Last, Middle First)";
                    author.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(author);
                    //Book Section
                    bookSection.Width = 150;
                    bookSection.Text = "Book Section (if applicable)";
                    bookSection.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookSection);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Year Published";
                    publishedYear.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Book Pages
                    bookPages.Width = 150;
                    bookPages.Text = "Issue";
                    bookPages.Location = new System.Drawing.Point(0, 200);
                    citationInformationPanel.Controls.Add(bookPages);
                    break;
                case 19:
                    //citation = $"{websiteCompany.Text}. \"{publishedYear.Text}.\" {bookTitle.Text}. {websiteUrl.Text}";
                    citationInformationPanel.Controls.Clear();
                    //Company
                    websiteCompany.Width = 150;
                    websiteCompany.Text = "Company";
                    websiteCompany.Location = new System.Drawing.Point(0, 0);
                    citationInformationPanel.Controls.Add(websiteCompany);
                    //Article Title
                    bookTitle.Width = 150;
                    bookTitle.Text = "Page Title Referencing";
                    bookTitle.Location = new System.Drawing.Point(0, 40);
                    citationInformationPanel.Controls.Add(bookTitle);
                    //Book Publisher
                    bookPublisher.Width = 150;
                    bookPublisher.Text = "Book Publisher";
                    bookPublisher.Location = new System.Drawing.Point(0, 80);
                    citationInformationPanel.Controls.Add(bookPublisher);
                    //Book Published Year
                    publishedYear.Width = 150;
                    publishedYear.Text = "Date Published";
                    publishedYear.Location = new System.Drawing.Point(0, 120);
                    citationInformationPanel.Controls.Add(publishedYear);
                    //Website URL
                    websiteUrl.Width = 150;
                    websiteUrl.Text = "Website URL";
                    websiteUrl.Location = new System.Drawing.Point(0, 160);
                    citationInformationPanel.Controls.Add(websiteUrl);
                    break;
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            switch (styleListBox.SelectedIndex)
            {
                case 0:
                    //APA - BOOK
                    //Sapolsky, R. M. (2017). Behave: The biology of humans at our best and worst. Penguin Books.
                    citation = $"{author.Text} ({publishedYear.Text}). {bookTitle.Text}. {bookPublisher.Text}.";
                    citationTextBox.Text = citation;
                    //MessageBox.Show("This is 0");
                    break;
                case 1:
                    // APA - Chapter in Book
                    //Dillard, J. P. (2020). Currents in the study of persuasion. In M. B. Oliver, A. A. Raney, & J. Bryant (Eds.), Media effects: Advances in theory and research (4th ed., pp. 115–129). Routledge.
                    citation = $"{author.Text} ({publishedYear.Text}).{bookSection.Text}. {bookTitle.Text}. {bookPages.Text} {bookPages.Text} {bookPublisher.Text}";
                    citationTextBox.Text = citation;
                    break;
                case 2:
                    //APA - Print Journal
                    //Weinstein, J. (2009). “The market in Plato’s Republic.” Classical Philology, 104(4), 439-458.                   
                    citation = $"{author.Text} ({publishedYear.Text}).{bookPublisher.Text} {bookTitle.Text}.{bookPages.Text}";
                    citationTextBox.Text = citation;
                    break;
                case 3:
                    //APA - Electronic Journal
                    //Grady, J. S., Her, M., Moreno, G., Perez, C., & Yelinek, J. (2019). Emotions in storybooks: A comparison of storybooks that represent ethnic and racial groups in the United States. Psychology of Popular Media Culture, 8(3), 207–217. https://doi.org/10.1037/ppm0000185
                    //MessageBox.Show("THis is 3");
                    citation = $"{author.Text} ({publishedYear.Text}).{bookPublisher.Text} {bookTitle.Text}.{bookPages.Text} {websiteUrl.Text}";
                    citationTextBox.Text = citation;
                    break;
                case 4:
                    //APA - Website
                    //Bologna, C. (2019, October 31). Why some people with anxiety love watching horror movies. HuffPost. https://www.huffpost.com/entry/anxiety-love-watching-horror-movies_l_5d277587e4b02a5a5d57b59e
                    //MessageBox.Show("THis is 4");
                    citation = $"{author.Text} ({publishedYear.Text}). {bookTitle.Text}.{websiteCompany.Text} {websiteUrl.Text}";
                    citationTextBox.Text = citation;
                    break;
                case 5:
                    //MLA - BOOK in print
                    //Card, Claudia. The Atrocity Paradigm: A Theory of Evil. Oxford UP, 2005.
                    //MessageBox.Show("THis is 5");
                    citation = $"{author.Text}. {bookTitle.Text}. {bookPublisher.Text}, {publishedYear.Text}";
                    citationTextBox.Text = citation;
                    break;
                case 6:
                    //MLA - Ebook
                    //Gaither, Milton. Homeschool: An American History. Palgrave Macmillan, 2017. SpringerLink, doi-org.pitt.idm.oclc.org/10.1057/978-1-349-95056-0.
                    citation = $"{author.Text}. {bookTitle.Text}. {bookPublisher.Text}, {publishedYear.Text}. {websiteUrl.Text}";
                    citationTextBox.Text = citation;
                    break;
                case 7:
                    //MLA - An article in a print journal
                    //Doggart, Julia. "Minding the Gap: Realizing Our Ideal Community Writing Assistance Program." The Community Literacy Journal, vol. 2, no. 1, 2007, pp. 71-80. 
                    citation = $"{author.Text}. \"{bookSection.Text}.\"{bookTitle.Text}, {publishedYear.Text}, pp. {bookPages.Text}";
                    citationTextBox.Text = citation;
                    break;
                case 8:
                    //MLA - An article in an electronic journal
                    //Sherrard-Johnson, Cherene. "'A Plea for Color': Nella Larsen's Iconography of the Mulatta." American Literature, vol. 76, no. 4, 2004, pp. 833-869, doi: 10.1215/00029831-76-4-833.
                    citation = $"{author.Text}. \"{bookSection.Text}.\" {bookTitle.Text}, {publishedYear.Text}, pp. {bookPages.Text} {websiteUrl.Text}";
                    citationTextBox.Text = citation;
                    break;
                case 9:
                    //MLA - A encyclopedia entry
                    //“Patanjali.” Benét’s Reader’s Encyclopedia, edited by Bruce Murphy, 4th ed., HarperCollins Publishers, 1996, p. 782.
                    citation = $"\"{bookSection.Text}\", {bookTitle.Text}, edited by {author.Text}, {bookPublisher.Text}, {publishedYear.Text}, pp. {bookPages.Text}";
                    citationTextBox.Text = citation;
                    break;
                case 10:
                    // MLA - A government publication
                    //United States, Federal Maritime Commission. Hawaiian Trade Study: An Economic Analysis. Government Printing Office, 1978. 
                    citation = $"{author.Text}. {bookTitle.Text}. {bookPublisher.Text}, {publishedYear.Text}.";
                    citationTextBox.Text = citation;
                    break;
                case 11:
                    //MLA - An interview you conducted
                    //Brandt, Deborah. Personal interview. 28 May 2008.
                    citation = $"{author.Text}. Personal Interview. {publishedYear.Text}.";
                    citationTextBox.Text = citation;
                    break;
                case 12:
                    //MLA - A film/DVD
                    //The Usual Suspects. Directed by Bryan Singer, performances by Kevin Spacey, Gabriel Byrne, Chazz Palminteri, Stephen Baldwin, and Benicio Del Toro. Polygram, 1995. 
                    citation = $"{bookTitle.Text}. Directed by {author.Text}, performances by {bookSection.Text}. {bookPublisher.Text}, {publishedYear.Text}.";
                    citationTextBox.Text = citation;
                    break;
                case 13:
                    //MLA - A Page on a Website with no author
                    //"Stunning Lakeside View on Lake Erie." VisitPA, Commonwealth of Pennsylvania, 7 June 2018, www.visitpa.com/article/stunning-lakeside-views-lake-erie.
                    citation = $"\"{bookTitle.Text}.\" {websiteCompany.Text}, {publishedYear.Text}, {websiteUrl.Text}.";
                    citationTextBox.Text = citation;
                    break;
                case 14:
                    //MLA - A Page on a Website with an author
                    //Del Castillo, Inigo. "How Not to Kill Your Houseplants, According to Botanists." Apartment Therapy, 29 Jan. 2020, www.apartmenttherapy.com/houseplant-tips-botanists-36710191.
                    citation = $"{author.Text}. \"{bookTitle.Text}.\" {websiteCompany.Text}, {publishedYear.Text}, {websiteUrl.Text}.";
                    citationTextBox.Text = citation;
                    break;
                case 15:
                    //MLA - Artwork from website
                    //Sherald, Amy. Former First Lady, Michelle Obama. 2018. National Portrait Gallery, npg.si.edu/object/npg_NPG.2018.15.
                    citation = $"{author.Text}. {bookTitle.Text}. {publishedYear.Text}. {websiteCompany.Text}, {websiteUrl.Text}.";
                    citationTextBox.Text = citation;
                    break;
                
                case 16:
                    //Chicago - A book in print
                    // Michael Pollan, The Omnivore's Dilemma: A Natural History of Four Meals (New York: Penguin, 2006), 99–100.
                    citation = $"{author.Text}, {bookTitle.Text} ({bookPublisher.Text},{publishedYear.Text}), {bookPages.Text}.";
                    citationTextBox.Text = citation;
                    break;
                
                case 17:
                    //Chicago - An article in a print journal
                    //Gueorgi Kossinets and Duncan J. Watts, “Origins of Homophily in an Evolving Social Network,” American Journal of Sociology 115 (2009): 411, accessed February 28, 2010, doi:10.1086/599247.
                    citation = $"{author.Text}, \"{bookSection.Text}.\" {bookTitle.Text} ({publishedYear.Text}): {bookPages.Text}.";
                    citationTextBox.Text = citation;
                    break;


                case 18:
                    //Chicago -- An article in an electronic journal
                    //Joshua I. Weinstein, "The Market in Plato’s Republic," Classical Philology 104 (2009): 440.
                    citation = $"{author.Text}, \"{bookSection.Text}.\" {bookTitle.Text} ({publishedYear.Text}): {bookPages.Text}";
                    citationTextBox.Text = citation;
                    break;

                case 19:
                    //Chicago - A website
                    //Google. 2009. “Google Privacy Policy.” Last modified March 11. http://www.google.com/intl/en/privacypolicy.html.
                    citation = $"{websiteCompany.Text}. \"{publishedYear.Text}.\" {bookTitle.Text}. {websiteUrl.Text}";
                    citationTextBox.Text = citation;
                    break;

            }
        }
    }
}





