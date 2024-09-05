using CommunityIS.Service.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Core
{
    public class CommunityService : ICommunityService
    {
        protected CommunityContext _context;

        public CommunityService(CommunityContext context)
        {
            _context = context;
        }

        public void AddCommunity(Community community)
        {
            _context.Communities.Add(community);
            _context.SaveChanges();
        }

        public void UpdateCommunity(Community community)    
        {
            var existingCommunity = _context.Communities.Find(community.CommunityId);
            if (existingCommunity != null)
            {
                existingCommunity.CommunityName = community.CommunityName;
                existingCommunity.FacultyId = community.FacultyId;
                _context.SaveChanges();
            }
        }

        public void DeleteCommunity(int communityId)
        {
            var community = _context.Communities.Find(communityId);
            if (community != null)
            {
                _context.Communities.Remove(community);
                _context.SaveChanges();
            }
        }

        public Community GetCommunityById(int communityId)
        {
            var community = _context.Communities.Find(communityId);
            return community;
        }

        public List<Community>  GetAllCommunities()
        {
            return _context.Communities
                       .Include(c => c.Faculty)
                       .ToList();
        }

        
    }

    interface ICommunityService
    {
        void AddCommunity(Community community);
        void UpdateCommunity(Community community);
        void DeleteCommunity(int communityId);
        Community GetCommunityById(int communityId);
        List<Community> GetAllCommunities();
    }
}
