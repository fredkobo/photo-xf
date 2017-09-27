using System;
using Xamarin.Forms;

namespace Photo
{
    public partial class PhotoPage : ContentPage
    {
        public PhotoPage()
        {
			InitializeComponent();

			CameraButton.Clicked += CameraButton_Clicked;
        }

		private async void CameraButton_Clicked(object sender, EventArgs e)
		{
			var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });


			if (photo != null)
				PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });

			var stream = photo.GetStream();
			ConvertImageToBase64String(stream);
		}

		private async void ConvertImageToBase64String(System.IO.Stream stream)
		{
			var bytes = new byte[stream.Length];
			await stream.ReadAsync(bytes, 0, (int)stream.Length);
			string base64 = Convert.ToBase64String(bytes);
		}
    }
}
