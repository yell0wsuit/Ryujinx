using System.Collections.Generic;

namespace Ryujinx.Ui.Common.Models.Github
{
    public class GithubReleasesJsonResponse
    {
        public string Name { get; set; }
        public string Body { get; set; }
        public List<GithubReleaseAssetJsonResponse> Assets { get; set; }
    }
}