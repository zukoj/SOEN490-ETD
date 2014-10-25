﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Team_Dispatcher
{
    class Team
    {
        String name;
        TeamMember[] members;
        int memberCount = 0;
        String departure;

        public Team()
        {
            name = "Alpha";
            members = new TeamMember[400];
        }
        public Team(String name)
        {
            this.name = name;
            members = new TeamMember[400];
        }

        public bool addMember(TeamMember mem)
        {
            if(memberCount < 2)
            {
                members[memberCount] = mem;
                memberCount++;
                return true;
            }
            return false;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        //Generate shape to represent team on screen
        public void draw()
        {

        }
    }
}