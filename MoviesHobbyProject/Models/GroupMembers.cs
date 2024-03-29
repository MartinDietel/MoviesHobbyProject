﻿using System.ComponentModel.DataAnnotations;

namespace MoviesHobbyProject.Models
{
    public class GroupMembers
    {
        [Key]
        public int GroupMembersID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MemberBio { get; set; }
        public string FavMovieReason { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Slug
        {
            get
            {
                if (FullName == null)
                    return "";
                else
                    return FullName.Replace(' ', '-');
            }
        }
    }
}
