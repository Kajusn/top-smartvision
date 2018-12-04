using LostAndFound.Models;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LostAndFound
{
    class FoundController
    {
        public async static void PickPic(ContentPage instance)
        {
            var uniqueFileName = $@"{Guid.NewGuid()}.jpg";

            await CrossMedia.Current.Initialize();

            try
            {
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await instance.DisplayAlert("No Camera", ":( No camera available.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    Directory = "Sample",
                    Name = uniqueFileName
                });

                if (file == null)
                    return;

                await instance.DisplayAlert("File Location", file.Path, "OK");

                Image image = new Image();
                image.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    return stream;
                });
            }
            catch(MediaPermissionException)
            {
                await instance.DisplayAlert("No Camera Permissions", ":( No camera permissions granted. Please check them in App info > Permissions (:", "OK");
            }
            
        }

        public static void Save(IFoundModel model, ContentPage instance)
        {

        }
    }
}
