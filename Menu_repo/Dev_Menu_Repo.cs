using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_repo
{
    public class DevMenuRepository
    {
        private List<DevMenu> _listOfContent = new List<DevMenu>();

        //Create
        public void AddContentToList(DevMenu content)
        {
            _listOfContent.Add(content);

        }

        //Read
        public List<DevMenu> GetContentList()
        {
            return _listOfContent;

        }

        //Update
        public bool UpdateExistingContent(string originalItem, DevMenu newContent)
        {
            // Find the content
            DevMenu oldContent = GetContentByItem(originalItem);


            //Update the content
            if (oldContent != null)
            {
                oldContent.MealNumber = newContent.MealNumber;
                oldContent.MealName = newContent.MealName;
                oldContent.Description = newContent.Description;
                oldContent.Ingredients = newContent.Ingredients;
                oldContent.Price = newContent.Price;

                return true;
            }
            else
            {
                return false;
            }
        }



        //Delete
        public bool RemoveContentFromList(string title)
        {
            DevMenu content = GetContentByItem(title);

            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;

            }
            else
            {
                return false;
            }

        }


        //Helper method
        public DevMenu GetContentByItem(string title)
        {
            foreach (DevMenu content in _listOfContent)
            {
                if (content.MealName.ToLower() == title.ToLower())
                {
                    return content;

                }
            }
            return null;
        }
    }
}

