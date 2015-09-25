using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Screenshotautoupload
{
    class ScreenshotUploader
    {
        public ImgurResponseModel uploadScreenshot(string imagePath)
        {
            ImgurResponseModel imgurResponseModel = new ImgurResponseModel();

            try
            {
                using (WebClient web = new WebClient())
                {
                    web.Headers.Add("Authorization", "Client-ID " + Program.client_id);
                    var values = new NameValueCollection
                    {
                        { "image",  Convert.ToBase64String(File.ReadAllBytes(imagePath)) }
                    };

                    byte[] imgurReturnArray = web.UploadValues("https://api.imgur.com/3/upload.json", values);
                    string imgurResponse = System.Text.Encoding.Default.GetString(imgurReturnArray);
                    dynamic responseModel = JsonConvert.DeserializeObject(imgurResponse);

                    imgurResponseModel.id = responseModel.data.id;
                    imgurResponseModel.link = responseModel.data.link;
                    imgurResponseModel.deletehash = responseModel.data.deletehash;
                }
            }
            catch (WebException) { }

            return imgurResponseModel;
        }
    }
}
