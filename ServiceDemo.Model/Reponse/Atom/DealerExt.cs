using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDemo.Model.Reponse.Atom
{
    [ProtoContract]
    public class DealerExt
    {
        [ProtoMember(1)]
        public Int32 DealerID { get; set; }

        //,[LastModifyTime]
        //,[VendorMapId]
        //,[VendorMapPic]
        //,[VendorWebSite]
        //,[VendorEmail]
        //,[Vendor2DomainName]
        //,[Weighing]
        //,[BrandGroupID]
        //,[IconProportion]
        //,[MainSeries]
        //,[VendorShopPic]
        //,[AutoSiteDomain]
        //,[IsShowMap]
        //,[CallCenterNumber]
        //,[TelShowType]
        //,[CallCenterOtherNumber]
        //,[Summary]
        //,[DealerPostCode]
        //,[TrafficInfo]
        //,[DealerFaxNumbers]
        //,[ActiveScore]
        //,[AutoSiteRunStatus]
        //,[BannerPhotoPath]
        //,[ExternalID]
        //,[SiteUrl]
        //,[GroupID]
        //,[GroupFullName]
        //,[GroupLogoUrl]
        //,[ThemeID]
    }
}
