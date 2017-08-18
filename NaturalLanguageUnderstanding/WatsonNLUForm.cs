/*
 * Copyright 2017 IBM Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace WatsonDeveloperCloudExample
{
    public partial class NLUForm : Form
    {

        public NLUForm()
        {
            InitializeComponent();
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            string corpus = this.corpusTextBox.Text;
            this.jsonTreeView.Nodes.Clear();
            this.jsonTreeView.Nodes.Add(Json2Tree("Result", Watson.NLU.analyzeText(username, password, corpus)));
        }

        private static TreeNode Json2Tree(string key, JObject obj)
        {
            //create the parent node
            TreeNode treeNode = new TreeNode();
            //change the display Content of the parent
            treeNode.Text = key;
            //loop through the obj. all token should be pair<key, value>
            foreach (var token in obj)
            {
                //check if the value is of type obj recall the method
                if (token.Value.Type == JTokenType.Object)
                {
                    treeNode.Nodes.Add(Json2Tree(token.Key, (JObject)token.Value));
                }
                //if type is of array
                else if (token.Value.Type == JTokenType.Array)
                {
                    treeNode.Nodes.Add(Json2Tree(token.Key, (JArray)token.Value));
                }
                else
                {
                    //change the value into N/A if value == null or an empty string 
                    if (token.Value.ToString() == "")
                    {
                        TreeNode valueNode = new TreeNode();
                        valueNode.Text = token.Key;
                        valueNode.Nodes.Add("N/A");
                        treeNode.Nodes.Add(valueNode);
                    }
                    else
                    {
                        TreeNode valueNode = new TreeNode();
                        valueNode.Text = token.Key;
                        valueNode.Nodes.Add(token.Value.ToString());
                        treeNode.Nodes.Add(valueNode);                        
                    }                    
                }
            }
            return treeNode;

        }

        private static TreeNode Json2Tree(string name, JArray jsonArray)
        {
            int idx = -1;
            // Create Child Node
            TreeNode arrayNode = new TreeNode();
            // Set Child Name to Array Name
            arrayNode.Text = name;
            //loop though the array
            foreach (var value in jsonArray.Children())
            {
                idx += 1;
                //check if value is an Array of objects
                if (value.Type == JTokenType.Object)
                {
                    arrayNode.Nodes.Add(Json2Tree(name + "[" + idx + "]", (JObject)value));
                }
                //regular array string, int, etc
                else if (value.Type == JTokenType.Array)
                {
                    arrayNode.Nodes.Add(Json2Tree(name + "[" + idx + "]", (JArray)value));                    
                }
                else
                {
                    //change the value into N/A if value == null or an empty string 
                    if (value.ToString() == "")
                    {
                        TreeNode valueNode = new TreeNode();
                        valueNode.Text = name + "[" + idx + "]";
                        valueNode.Nodes.Add("N/A");
                        arrayNode.Nodes.Add(valueNode);
                    }
                    else
                    {
                        TreeNode valueNode = new TreeNode();
                        valueNode.Text = name + "[" + idx + "]";
                        valueNode.Nodes.Add(value.ToString());
                        arrayNode.Nodes.Add(valueNode);
                    }
                }
            }
            return arrayNode;
        }

    }
}
