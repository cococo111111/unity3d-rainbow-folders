﻿/*
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Borodar.RainbowItems.Editor.Settings
{
    public class CustomBrowserIconSettings : ScriptableObject
    {
        public List<Folder> Folders;

        public Texture2D GetTextureByItemName(string folderName, bool small = true)
        {
            var folder = Folders.FirstOrDefault(x => x.FolderName.Equals(folderName));

            if (folder == null) { return null; }

            return small ? folder.SmallIcon : folder.LargeIcon;
        }
    }
}