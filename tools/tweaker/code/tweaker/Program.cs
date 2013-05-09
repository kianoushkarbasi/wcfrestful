using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Xml;
using System.Configuration;
using System.Xml.Serialization;
using System.Net;
using System.Drawing;
using Integrator.BL;

namespace Tweaker
{
    class Program
    {
        static fanlive4Entities entity = new fanlive4Entities();
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Change name of microsites.");
            Console.WriteLine("2 - Change name of profiles.");
            Console.WriteLine("3 - Check emails in users");
            Console.WriteLine("4 - Fix duplicates");
            Console.WriteLine("5 - Fix Not exitst one with Regular");
            Console.WriteLine("6 - Add fanid for each microsite");
            Console.WriteLine("7 - Add dealers ranking");
            Console.WriteLine("8 - Remove duplicate players");
            Console.WriteLine("9 - Switch back to previous description");
            Console.WriteLine("9 - Switch back to previous description");
            Console.WriteLine("10 - Change the name of the microsites in taa_microsite");
            Console.WriteLine("11 - Copy images to fanid");
            Console.WriteLine("12 - Download microsites has been created using xml files to have logos");
            Console.WriteLine("13 - Change http://dev. to http://thefanorama.com");
            Console.WriteLine("14 - Change description button");





            Console.Write("Option:");
            string option = Console.ReadLine();
            if (option.Equals("1"))
            {
                string path = @"C:\backup\archives1\microsite";
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                var filesInFolder = dir.GetFiles();

                foreach (System.IO.FileInfo f in filesInFolder)
                {
                    string[] newname = Regex.Split(f.Name, "microsite");
                    f.CopyTo(string.Format("c:/archives/microsite/microsite{0}", newname[1]), true);
                    Console.WriteLine(newname[1]);

                }
            }
            else if (option.Equals("2"))
            {
                string path = @"C:\backup\archives1\profile";
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                var filesInFolder = dir.GetFiles();

                foreach (System.IO.FileInfo f in filesInFolder)
                {
                    string[] newname = Regex.Split(f.Name, "fan");
                    f.CopyTo(string.Format("c:/archives/profile/fan{0}", newname[1]), true);
                    Console.WriteLine(newname[1]);

                }
            }

            else if (option.Equals("3"))
            {
                //fanlive4Entities entity = new fanlive4Entities();
                //foreach (User user in entity.Users)
                //{
                //    if (!IsValid(user.Email) )
                //    {
                //        BadUser baduser = new BadUser();

                //        entity.BadUsers.AddObject(baduser);
                //    }
                //}
            }
            else if (option.Equals("4"))
            {
                fanlive4Entities entity = new fanlive4Entities();
                string pricelist = ConfigurationManager.AppSettings["duplicatedPricelist"].ToString();
                var duplicates = (from d in entity.UserProfiles where d.PropertyDefinitionID == 69 && d.PropertyValue.Equals(pricelist) select d).DefaultIfEmpty();
                var duplicateTable = (from dc in duplicates
                                      group dc by dc.UserID into g
                                      let c = g.Count()
                                      where c > 1
                                      select new { g.Key, c }).DefaultIfEmpty();
                foreach (var dup in duplicateTable)
                {
                    if (dup != null)
                    {
                        //find the userid inside duplicates
                        var repeated = from d in duplicates where dup.Key == d.UserID select d;
                        int counter = 0;
                        // loop through all of them 
                        if (repeated != null)
                        {
                            foreach (var rep in repeated)
                            {
                                if (rep != null && counter > 0)
                                {
                                    entity.UserProfiles.DeleteObject(rep);
                                    Console.WriteLine(rep.UserID);
                                }
                                counter++;

                            }
                        }
                    }
                }
                entity.SaveChanges();
            }
            else if (option.Equals("5"))
            {
                fanlive4Entities entity = new fanlive4Entities();
                string path = string.Format(@"c:\kianoush\profile\");
                string fullpath;
                List<string> result = new List<string>();
                List<string> profileFiles = listAllFiles(path);
                foreach (string profileFile in profileFiles)
                {

                    fullpath = string.Format("{0}{1}", path, profileFile);
                    try
                    {
                        if (System.IO.File.Exists(fullpath))
                        {
                            using (XmlTextReader xmlreader = new XmlTextReader(fullpath))
                            {

                                InsertIntoDB(xmlreader, entity);
                            }
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0} hasn't been uploaded", profileFile));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else if (option.Equals("6"))
            {
                fanlive4Entities entity = new fanlive4Entities();
                var createdmicrosites = from m in entity.TAA_Microsite where m.IntegratorRetrievalCode != null select m;
                foreach (var microsite in createdmicrosites)
                {
                    TAA_FanID newfan = new TAA_FanID();
                    newfan.Accent = microsite.Accent;
                    newfan.PrimaryColor = microsite.PrimaryColour;
                    newfan.SecondaryColor = microsite.SecondaryColour;
                    newfan.City = microsite.City;
                    newfan.TeamName = microsite.TeamName;
                    newfan.CreatedByUserID = -1;
                    newfan.CreatedOnDate = DateTime.Now;
                    newfan.Deleted = false;
                    newfan.School = microsite.School;
                    newfan.City = microsite.City;
                    newfan.DesignName = microsite.TeamName;
                    newfan.MicrositeID = microsite.MicrositeID;
                    newfan.PrimaryColorID = microsite.PrimaryColorID;
                    newfan.SecondaryColorID = microsite.SecondaryColorID;
                    newfan.AccentColorID = microsite.AccentColorID;
                    int sportid = -1;

                    if (microsite.SportID == null)
                        sportid = -1;
                    else
                        sportid = (int)microsite.SportID;
                    newfan.TAASportID = sportid;
                    string sport;
                    sport = newfan.Sport;
                    if (newfan.Sport == null)
                        sport = "-1";
                    newfan.Sport = sport;
                    entity.TAA_FanID.AddObject(newfan);

                }
                entity.SaveChanges();
            }
            else if (option.Equals("7"))
            {
                string path = string.Format(@"d:\kianoush\dealers\dealer.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(Table));
                StreamReader reader = new StreamReader(path);
                Table dealers = (Table)serializer.Deserialize(reader);
                reader.Close();
                string customerid;
                fanlive4Entities entity = new fanlive4Entities();
                StreamWriter writer = new StreamWriter(@"d:\kianoush\dealers\notimported.csv");
                foreach (var dealer in dealers.Items)
                {
                    customerid = dealer.Cell[0].Data.Trim();
                    var userprofile = (from f in entity.UserProfiles where f.PropertyValue.Trim().Equals(customerid) select f).FirstOrDefault();
                    if (userprofile != null)
                    {
                        UserProfile newuserprofile = new UserProfile();
                        newuserprofile.UserID = userprofile.UserID;
                        newuserprofile.Visibility = 2;
                        newuserprofile.PropertyDefinitionID = 68;
                        newuserprofile.PropertyValue = "True";
                        newuserprofile.LastUpdatedDate = DateTime.Now;
                        entity.UserProfiles.AddObject(newuserprofile);

                        newuserprofile = new UserProfile();

                        newuserprofile.UserID = userprofile.UserID;
                        newuserprofile.Visibility = 2;
                        newuserprofile.PropertyDefinitionID = 67;
                        newuserprofile.PropertyValue = dealer.Cell[4].Data;
                        newuserprofile.LastUpdatedDate = DateTime.Now;
                        entity.UserProfiles.AddObject(newuserprofile);
                        Console.WriteLine(customerid);

                    }
                    else
                    {

                        writer.WriteLine(customerid);
                    }

                }
                writer.Close();
                entity.SaveChanges();
            }
            else if (option.Equals("8"))
            {
                fanlive4Entities entity = new fanlive4Entities();
                string path = string.Format(@"c:\kianoush\microsite\");
                var players = from p in entity.TAA_RoleCards select p;
                string fullpath;
                List<string> result = new List<string>();
                List<string> profileFiles = listAllFiles(path);
                foreach (string profileFile in profileFiles)
                {

                    fullpath = string.Format("{0}{1}", path, profileFile);
                    try
                    {
                        if (System.IO.File.Exists(fullpath))
                        {
                            using (XmlTextReader xmlreader = new XmlTextReader(fullpath))
                            {

                            }
                        }
                        else
                        {
                            Console.WriteLine(string.Format("{0} hasn't been uploaded", profileFile));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else if (option.Equals("9"))
            {
                fanlive4Entities entity = new fanlive4Entities();
                DateTime yesterday = DateTime.Now.AddDays(-2);
                InsertNewProduct(entity, yesterday, "D0008", 13);
                InsertNewProduct(entity, yesterday, "D0010", 8);
                InsertNewProduct(entity, yesterday, "D0012", 2);


            }
            else if (option.Equals("10"))
            {
                fanlive4Entities entity = new fanlive4Entities();

                foreach (var microsite in entity.TAA_Microsite)
                {
                    if (microsite.URL != null)
                        if (microsite.URL.Contains("thefanorama.com"))
                        {
                            //string temp = microsite.URL.Replace("slp.", string.Empty);
                            //if (microsite.URL.Contains("blondgorilla"))
                            //    temp = temp.Replace("blondgorilla.", string.Empty);4
                            string temp = microsite.URL.Replace("thefanorama.com", "dev.thefanorama.blondgorilla.com");
                            microsite.URL = temp;
                            Console.WriteLine(temp);
                        }
                }
                entity.SaveChanges();

            }
            else if (option.Equals("11"))
            {
                fanlive4Entities entity = new fanlive4Entities();
                var microsites = entity.TAA_Microsite.Where(p => p.CreatedFromSLP == false).DefaultIfEmpty();
                string path = string.Empty;
                string target = string.Empty;
                string fileName = string.Empty;
                string fileExtention = string.Empty;

                foreach (var microsite in microsites)
                {
                    string mainpath = @"D:\inetpub\wwwroot\FanoramaLive\";
                    path = string.Format(@"{0}MicrositeImages/{1}/",mainpath, microsite.MicrositeID);
                    List<string> files = listAllFiles(path);
                    if (files.Count > 0 )
                    {
                        int indexMax = findLargestFile(files, path);
                        var fanid = entity.TAA_FanID.Where(p => p.MicrositeID == microsite.MicrositeID).FirstOrDefault();
                        
                        fileName = Guid.NewGuid().ToString();
                        string oldpath = string.Format("{0}{1}", path, files[indexMax]);
                        fileExtention = Path.GetExtension(oldpath);
                        string targetBasePath = string.Format(@"{0}/FanIdImages/{1}/",mainpath, fanid.FanID);
                        if (!Directory.Exists(targetBasePath))
                            Directory.CreateDirectory(targetBasePath);
                        target = string.Format(@"{0}/FanIdImages/{1}/{2}{3}",mainpath, fanid.FanID, fileName, fileExtention);
                        File.Copy(oldpath, target,true);
                        fanid.UserUploadedGraphic = target.Replace(mainpath,"http://thefanorama.com");
                        target = string.Format(@"{0}/FanIdImages/{1}/{2}.tif",mainpath, fanid.FanID, fileName);
                        if(!File.Exists(target))
                            File.Copy(oldpath, target);
                        fanid.GAUploadedGraphic = target.Replace(mainpath, "http://thefanorama.com");
                        Console.WriteLine(target);
                        
                    }

                }
                entity.SaveChanges();



            }
            else if (option.Equals("12"))
            {
                var webClient = new WebClient();

                var fanImagesPath = @"D:\inetpub\wwwroot\FanoramaLive\MicrositeImages\";
                var filepath = "";                
                var sceneSevenUrl = "http://216.23.175.26/is/image/TeamworkAthletic/customerUploads/";
                string sceneFilePath;
                var microsites = entity.TAA_Microsite.Where(p => p.CreatedFromSLP == false).DefaultIfEmpty();
                
                foreach (var microsite in microsites)
                {
                    if (!string.IsNullOrEmpty(microsite.TeamLogo))
                    {
                        filepath = string.Format("{0}{1}", fanImagesPath, microsite.MicrositeID);
                        if (!Directory.Exists(filepath))
                        {
                            Directory.CreateDirectory(filepath);
                        }
                        sceneFilePath = string.Format("{0}{1}", sceneSevenUrl, microsite.TeamLogo);
                        SaveLogo(sceneFilePath, microsite, fanImagesPath);
                    }
                }
                entity.SaveChanges();
            }

            else if (option.Equals("13"))
            {
                var fans = entity.TAA_FanID.Where(e => e.UserUploadedGraphic.Contains("dev."));
                foreach (var fan in fans)
                {
                    fan.UserUploadedGraphic = fan.UserUploadedGraphic.Replace(
                        "http://dev.thefanorama.blondgorilla.com", "http://thefanorama.com");
                    if(fan.GAUploadedGraphic!=null)
                    fan.GAUploadedGraphic = fan.GAUploadedGraphic.Replace("http://dev.thefanorama.blondgorilla.com", "http://thefanorama.com");
                }

                entity.SaveChanges();
            }
            else if (option.Equals("14"))
            {
                var fans = entity.CAT_Products.Where(e => e.Free1.Contains("<img src=\"http://thefanorama.com/Portals/0/images/click_to_design.png\">"));
                foreach (var fan in fans)
                {
                    fan.Free1 = fan.Free1.Replace("<img src=\"http://thefanorama.com/Portals/0/images/click_to_design.png\">", "<a href=\"#\"><img onclick=\"ShowDesignZoneDialog();\" src=\"http://thefanorama.com/Portals/0/images/click_to_design.png\"></a>");
                  fan.Free2 = fan.Free2.Replace("<img src=\"http://thefanorama.com/Portals/0/images/click_to_design.png\">", "<a href=\"#\"><img onclick=\"ShowDesignZoneDialog();\" src=\"http://thefanorama.com/Portals/0/images/click_to_design.png\"></a>");
                  fan.Free3 = fan.Free3.Replace("<img src=\"http://thefanorama.com/Portals/0/images/click_to_design.png\">", "<a href=\"#\"><img onclick=\"ShowDesignZoneDialog();\" src=\"http://thefanorama.com/Portals/0/images/click_to_design.png\"></a>");
                }

                entity.SaveChanges();
            }


            //else if (option.Equals("9"))
            //{
            //    NewTweaker.dnnolddescriptionEntities oldentities = new NewTweaker.dnnolddescriptionEntities();
            //    fanlive4Entities newentity = new fanlive4Entities();
            //    string temp;
            //    foreach (NewTweaker.CAT_Products oldproduct in oldentities.CAT_Products)
            //    {                    
            //        var newproduct = newentity.CAT_Products.Where(o => o.ProductID.Equals(oldproduct.ProductID)).FirstOrDefault();
            //       temp = newproduct.Free1;
            //        if(newproduct!=null)
            //        {
            //            newproduct.Free1 = oldproduct.Free1;
            //            newproduct.Free2 = oldproduct.Free2;
            //            newproduct.Free3 = oldproduct.Free3;
            //        }
            //        Console.WriteLine(string.Format("Product number {0} has been changed description1 {1} to {2}",newproduct.ProductID,temp, newproduct.Free1));
            //    }
            //    newentity.AcceptAllChanges();
            //    newentity.SaveChanges();
            //}
            //else if (option.Equals("9"))
            //{
            //    fanlive4Entities entity = new fanlive4Entities();
            //    var products = from c in entity.CAT_Products where c.CMSProductID>193 && c.ProductName.Contains("Youth") select c;
            //    foreach (var product in products)
            //    {
            //        CAT_AdvCatProducts adv = new CAT_AdvCatProducts();
            //        adv.ProductID = product.ProductID;
            //        adv.AdvCatID = 12;
            //        entity.CAT_AdvCatProducts.AddObject(adv);
            //    }
            //    entity.SaveChanges();
            //}
            //else if (option.Equals("10"))
            //{
            //    fanlive4Entities entity = new fanlive4Entities();
            //    var products = from c in entity.CAT_Products where c.CMSProductID > 193 && c.ProductName.Contains("Adult") select c;
            //    foreach (var product in products)
            //    {
            //        CAT_AdvCatProducts adv = new CAT_AdvCatProducts();
            //        adv.ProductID = product.ProductID;
            //        adv.AdvCatID = 0;
            //        entity.CAT_AdvCatProducts.AddObject(adv);
            //    }
            //    entity.SaveChanges();
            //}
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static void SaveLogo(string sceneServerImage, TAA_Microsite taamicrosite, string logRootPath)
        {
            try
            {
                var newguid = Guid.NewGuid(); // Microsite is not created so make sure Image filenames are unique
                var fileName = Path.GetFileName(sceneServerImage);

                var newPath = Path.Combine(logRootPath, taamicrosite.MicrositeID.ToString());
                if (!Directory.Exists(newPath))
                    Directory.CreateDirectory(newPath);
                var webClient = new WebClient();
                var filepath = string.Format("{0}/{1}~!~{2}", newPath, newguid.ToString(), fileName);
                webClient.DownloadFile(sceneServerImage, filepath);
                var image = Image.FromFile(filepath);
                var header = ImageManipulation.ResizeImage(image, new Size(310, 60)); // site header
                var thumb = ImageManipulation.ResizeImage(image, new Size(82, 64));
                // thumb for microsite search results

                // using ~!~ as delimiter so later we can extract the original filename
                header.Save(newPath + "/header.jpg"); // Microsite Header
                thumb.Save(newPath + "/thumb.jpg"); // Thumbnail used in Search results

                image.Dispose();
                header.Dispose();
                thumb.Dispose();                
                if (entity.TAA_MicrositeLogos.Any(p => p.MicrositeID == taamicrosite.MicrositeID))
                    return;
                TAA_MicrositeLogos logo = new TAA_MicrositeLogos();
                logo.CreatedByUserID = -1;
                logo.CreatedOnDate = taamicrosite.CreatedOnDate;
                logo.Logo = fileName;
                logo.LogoName = Path.GetFileNameWithoutExtension(fileName);
                logo.MicrositeID = taamicrosite.MicrositeID;
                logo.Deleted = false;
                entity.TAA_MicrositeLogos.AddObject(logo);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static void InsertNewProduct(fanlive4Entities entity, DateTime yesterday, string stylenumber, int category)
        {
            var styleProducts = from f in entity.CAT_Products where f.EAN.Contains(stylenumber) && f.PublicationStart > yesterday select f;
            foreach (var styleProduct in styleProducts)
            {
                if (entity.CAT_AdvCatProducts.Any(d => d.CAT_Products.ProductID != styleProduct.ProductID))
                {
                    CAT_AdvCatProducts catproduct = new CAT_AdvCatProducts();
                    catproduct.AdvCatID = category;
                    catproduct.CAT_Products = styleProduct;
                    entity.CAT_AdvCatProducts.AddObject(catproduct);
                    Console.WriteLine(styleProduct.ProductID);
                }
            }

            entity.SaveChanges();
        }
        /// <summary>
        /// Very simple way to check whether the email address is correct or not
        /// </summary>
        /// <param name="emailaddress">The email address of the dealer in string fromat</param>
        /// <returns>It will return false if the email is not valid otherwise it will be true</returns>
        public static bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        private static int findLargestFile(List<string> files, string path)
        {

            long max = 0;
            int index = 0;
            int cnt = 0;
            string temp;
            foreach (string file in files
                )
            {
                 temp=string.Format("{0}{1}", path, file);

                FileInfo f = new FileInfo(temp);
                if (f.Length > max)
                {
                    max = f.Length;
                    index = cnt;
                }
                cnt++;
            }
            return index;
        }
        public static bool InsertIntoDB(XmlTextReader xml, fanlive4Entities entity)
        {
            bool insideOrganization = false;
            bool insideShippingAddress = false;
            bool insidePaymentType = false;
            bool insideBillingAddress = false;
            bool insideExtensions = false;
            bool insideDefaultMailingAddress = false;
            bool insideUsers = false;
            bool insidePyamentType = false;
            bool isDefault = false;
            User newdealer = new User();
            string paymentTerms = string.Empty;
            int userid = 0;
            bool net30 = false;
            UserProfile dealerprofile = new UserProfile();
            string pricelist = string.Empty;
            string nodeName = "";
            try
            {
                while (xml.Read())
                {

                    switch (xml.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            if (xml.Name.Equals("organization"))
                            {
                                insideOrganization = true;
                                newdealer = new User();
                                newdealer.IsSuperUser = false;
                            }
                            else if (xml.Name.Equals("users"))
                                insideUsers = true;
                            else if (xml.Name.Equals("shippingAddress"))
                                insideShippingAddress = true;
                            else if (xml.Name.Equals("paymentType"))
                                insidePyamentType = true;
                            else if (xml.Name.Equals("extensions"))
                                insideExtensions = true;
                            else
                                nodeName = xml.Name;
                            break;
                        case XmlNodeType.Text: //Display the text in each element.                        
                            if (nodeName.Equals("name"))
                            {
                                if (xml.Value != null && xml.Value.Contains("Charmaine"))
                                    newdealer.FirstName = xml.Value;
                                newdealer.DisplayName = xml.Value;

                            }
                            else if (nodeName.Equals("description"))
                            {
                                newdealer.LastName = xml.Value;
                            }
                            else if (insideShippingAddress)
                            {
                                if (nodeName.Equals("default") && xml.Value.Equals("true"))
                                {
                                    isDefault = true;
                                }
                                else if (isDefault)
                                {
                                }
                            }
                            else if (insideExtensions && !insideShippingAddress && !insideUsers && !insidePyamentType)
                            {

                                if (nodeName.Equals("taaAccountId") && xml.Value.Trim().Contains("162859"))
                                {



                                }
                                if (nodeName.Equals("priceList"))
                                {

                                    pricelist = xml.Value;

                                }
                                else if (nodeName.Equals("residential"))
                                {



                                }
                                else if (nodeName.Equals("country"))
                                {



                                }
                                else if (nodeName.Equals("email"))
                                {
                                    if (xml.Value.Contains("jbond@omegasports.net"))
                                        newdealer.Email = xml.Value;
                                    newdealer.Email = xml.Value;
                                    newdealer.Username = xml.Value;

                                }
                                else if (nodeName.Equals("paymentTerm"))
                                {
                                    paymentTerms = xml.Value;
                                    if (paymentTerms.Contains("NET30")) net30 = true;

                                }

                            }
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            if (xml.Name.Equals("organization"))
                            {

                                if (newdealer.Email != null && newdealer.FirstName != null && newdealer.LastName != null && IsValid(newdealer.Email))
                                {

                                    var user = (from u in entity.Users where u.Email.Equals(newdealer.Email) select u).FirstOrDefault();

                                    if (user != null)
                                    {
                                        /// password format is 2 from existing users
                                        Console.WriteLine(user.UserID);
                                        //lovely changes from teamwork
                                        if (pricelist.ToLower().Equals("dealer"))
                                            pricelist = "Regular";
                                        UserProfile userprofile = (from u in entity.UserProfiles where u.UserID == user.UserID && u.PropertyDefinitionID == 69 select u).FirstOrDefault();

                                        if (userprofile != null)
                                        {
                                            userprofile.PropertyValue = pricelist;
                                        }
                                        else
                                        {
                                            userprofile = new UserProfile();
                                            userprofile.UserID = user.UserID;
                                            userprofile.PropertyDefinitionID = 69;
                                            userprofile.Visibility = 2;
                                            user.LastModifiedOnDate = DateTime.Now;
                                            userprofile.PropertyValue = pricelist;
                                            entity.UserProfiles.AddObject(userprofile);
                                        }
                                        // entity.SaveChanges();

                                    }


                                }

                            }
                            else if (xml.Name.Equals("shippingAddress"))
                                insideShippingAddress = false;
                            else if (xml.Name.Equals("paymentType"))
                                insidePyamentType = false;
                            else if (xml.Name.Equals("extensions"))
                                insideExtensions = false;
                            else if (xml.Name.Equals("users"))
                                insideUsers = false;

                            break;

                    }
                }
                return true;
            }
            catch (XmlException exception)
            {
                Console.WriteLine(exception.Message);

                return false;
            }
        }
        /// <summary>
        /// List all files inside a folder
        /// </summary>
        /// <param name="path">a path that files need to be parsed</param>
        /// <returns>a list of files need to be parsed</returns>
        private static List<string> listAllFiles(string path)
        {
            List<string> files = new List<string>();
            if (Directory.Exists(path))
            {

                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                var filesInFolder = dir.GetFiles();
                foreach (System.IO.FileInfo f in filesInFolder)
                {
                    files.Add(f.Name);
                }
            }
            return files;
        }

    }
}
