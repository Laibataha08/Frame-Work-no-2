﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.IO;

namespace WindowsFormsApp4
{
    class Game
    {
        
        public static ArrayList allObjects = new ArrayList();

        private static Game a;

        private Game()
        {

        }

        public static Game getInstance()
        {
            if (a == null)
            {
                a = new Game();
            }
            return a;
        }

        public void AddObjects(GameObject G)
        {
            allObjects.Add(G);
        }

        public void update()
        {
            for (int idx = 0 ; idx < allObjects.Count; idx++)
            {
                GameObject g = (GameObject)allObjects[idx];
                g.updateposition();
            }
            
        }
    }
}
