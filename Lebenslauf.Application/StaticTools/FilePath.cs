using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebenslauf.Application.StaticTools
{
    public class FilePath
    {
        #region Base Iamge paths
        public static readonly string BaseImagePaths = "/content/images";
        public static readonly string BaseImagePathsServer = $"wwwroot{BaseImagePaths}";

        #endregion
        #region default
        public static readonly string DefaultAvatar = $"{BaseImagePaths}/default/default-avatar.png";
        #endregion
        #region Customer FeedBack Avatar
        public static readonly string CustomerFeedBackAvatar = $"{BaseImagePaths}/default/default-avatar/origin/";
        public static readonly string CustomerFeedBackAvatarServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePaths}/default/default-avatar/origin/");
        #endregion

        #region Customer Logo
        public static readonly string CustomerLogo = $"{BaseImagePaths}/customer-logo/origin/";
        public static readonly string CustomerLogoServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePaths}/customer-logo/origin/");
        #endregion

        #region Portfolio
        public static readonly string Portfolio = $"{BaseImagePaths}/portfolio/origin/";
        public static readonly string PortfolioServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathsServer}/portfolio/origin/");
        #endregion


        #region Avatar
        public static readonly string Avatar = $"{BaseImagePaths}/avatar/origin/";
        public static readonly string AvatarServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathsServer}/avatar/origin/");
        #endregion


        #region Resume
        public static readonly string Resume = $"{BaseImagePaths}/resume/origin/";
        public static readonly string ResumeServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathsServer}/resume/origin/");
        #endregion
    }
}

