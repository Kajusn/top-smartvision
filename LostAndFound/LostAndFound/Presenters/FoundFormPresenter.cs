using LostAndFound.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LostAndFound.Presenters
{
    class FoundFormPresenter: IFoundFormPresenter
    {
        private IFoundModel _model;
        public string TypeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersCode { get; set; }
        public string OcrText { get; set; }
        public Command PickPicCommand { get; }
        public Command SaveCommand { get; }
        public Command OcrCommand { get; }
        public Command CancelCommand { get; }
        private FoundPage instance;


        public FoundFormPresenter(IFoundModel model)
        {
            _model = model;
            instance = FoundPage.instance;
            PickPicCommand = new Command(() => PickPic());
            SaveCommand = new Command(() => Save());
            OcrCommand = new Command(() => OCR());
            CancelCommand = new Command(() => LoginOpen());
        }

        public void LoginOpen()
        {
            FormController.OpenLogin(instance);
        }

        public void PickPic()
        {
            // Calls method to write registration info to file
            FoundController.PickPic(instance);
        }

        public void Save()
        {
            _model.TypeID = TypeID;
            _model.FirstName = FirstName;
            _model.LastName = LastName;
            _model.PersCode = PersCode;
            // Calls method to write registration info to file
            FoundController.Save(_model, instance);
        }

        public void OCR()
        {

        }
    }
}
