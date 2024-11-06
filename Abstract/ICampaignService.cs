using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface ICampaignService
    {
        public void AddCampaign(Campaign campaign);
        public void RemoveCampaign(Campaign campaign);
        public void UpdateCampaign(Campaign campaign);

    }
}
