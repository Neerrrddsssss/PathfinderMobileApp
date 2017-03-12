using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PathfinderApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //sets the values of the dropdowns to the different constants
                ddlRace.Items.Add(new ListItem(Race.Dwarf));
                ddlRace.Items.Add(new ListItem(Race.Elf));
                ddlRace.Items.Add(new ListItem(Race.Human));

                ddlClass.Items.Add(new ListItem(ClassType.Rouge));
                ddlClass.Items.Add(new ListItem(ClassType.HarryPotter));
                ddlClass.Items.Add(new ListItem(ClassType.LunaLovegood));
            }
        }

        /*
        Examples of how to create a character/call functions 
        */ 
        protected void btnCreateChar_Click(object sender, EventArgs e)
        {
            
            //create an instance of the class type and race that are selected in the drop down
            ClassType ct = new ClassType(ddlClass.SelectedValue);
            Race r = new Race(ddlRace.SelectedValue);

            Character c = new Character(r, ct, 10, 10);

            //now that we have a character race/class
            //we will pass the character to the basestatbuilder to allocate/adjust stats
            c = BaseStatBuilder.buildRaceBaseStats(c);
            c = BaseStatBuilder.classCharacterAdjust(c);


            //demo a d20 roll 
            int rollNum = statGenerator.d20Roll();

            //proof of concept for UI
            lbChar.Items.Add(new ListItem(
                "Race: " + (c.getRace()).getType() +
                ", Class: " + (c.getClass()).getClassType() +
                ", Roll: " + rollNum
                ));

            

            ////testing character creation.  remove once basestat building is created...
            ////it shows why we dont do it this way.  it would be wayyy too long of a function if we
            ////checked for all the class/races from here.  (races X classes)
            //
            //if (r.getType().Equals(Race.Elf) && ct.getClassType().Equals(ClassType.Rouge))
            //{
            //
            //    Character c = new Character(r, ct, 10, 10, 
            //  (new BaseStat(10, 10, 10, "10")), (new BaseStat(10, 10, 10, "10")),
            //  (new BaseStat(10, 10, 10, "10")), (new BaseStat(10, 10, 10, "10")),
            //  (new BaseStat(10, 10, 10, "10")), (new BaseStat(10, 10, 10, "10")));
            //
            //    lbChar.Items.Add(new ListItem(
            //        "Race: " + (c.getRace()).getType() +
            //        ", Class: " + (c.getClass()).getClassType() +
            //        ", Roll: " + rollNum
            //        ));
            //}

        }
    }
}