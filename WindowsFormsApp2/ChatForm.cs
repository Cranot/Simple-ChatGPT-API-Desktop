using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChatAPI
{
	public partial class SimpleChatGPT : Form
	{
		private string apiKey;

		public SimpleChatGPT()
		{
			InitializeComponent();
		}

		bool checkInputs()
		{	
			if(string.IsNullOrEmpty(apibox.Text) || string.IsNullOrWhiteSpace(apibox.Text) || apibox.Text.Length < 2 || apibox.Text.Equals("YOUR API HERE"))
			{
				MessageBox.Show("Please enter a valid API key");
				return false;
			}
			else
			{
				apiKey = apibox.Text;
			}
			if(string.IsNullOrEmpty(promptbox.Text) || promptbox.Text.Length < 2 || promptbox.Text.Equals("Paste or write here"))
			{
				MessageBox.Show("Please enter a prompt that is at least 2 characters long", "Prompt Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		string cleanprompt(string prompt_text)
		{
			string cleanded_prompt = prompt_text?.Replace(Environment.NewLine, "\\n")?.Replace("\t", " ").Replace("\"", "\\\"");
			cleanded_prompt = System.Text.RegularExpressions.Regex.Replace(cleanded_prompt, @"\s+", " ");
			return cleanded_prompt;
		}
		
		void taxes(dynamic jsonResponse)
		{
			int prompt_tokens = jsonResponse.usage.prompt_tokens;
			int completion_tokens = jsonResponse.usage.completion_tokens;
			int total_tokens = jsonResponse.usage.total_tokens;

			int total_spent;
			if(string.IsNullOrEmpty(total_spent_box.Text) || !int.TryParse(total_spent_box.Text, out total_spent))
			{
				total_spent = 0;
			}
			total_spent += total_tokens;
			total_spent_box.Text = total_spent.ToString();
			prompt_token_box.Text = prompt_tokens.ToString();
			completion_token_box.Text = completion_tokens.ToString();
			total_token_box.Text = total_tokens.ToString();
			current_spent_box.Text = (0.000002 * total_tokens).ToString("0.000000") + "$";
			total_m_spent_box.Text = (0.000002 * total_spent).ToString("0.000000") + "$";
		}

		
		async Task <string> GetResponse(string prompt_text, string system_role)
		{
			string prompt = cleanprompt(prompt_text);
			var httpClient = new HttpClient();
			httpClient.Timeout = TimeSpan.FromSeconds(20);
			httpClient.DefaultRequestHeaders.Accept.Clear();
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			const string apiEndpoint = "https://api.openai.com/v1/chat/completions";
			var requestBody = new
			{
				model = "gpt-3.5-turbo",
				messages = new[]
				{
					new
					{
						role = "user",
						content = prompt
					}
				}
			};
			var requestContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
			var request = new HttpRequestMessage(HttpMethod.Post, apiEndpoint);
			request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
			request.Content = requestContent;

			// Send API request
			HttpResponseMessage response;
			try
			{
				response = await httpClient.SendAsync(request);
			}
			catch(HttpRequestException ex)
			{
				string errorMessage = "HTTP request failed: " + ex.Message;
				MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			// Process API response
			string responseContent;
			if(response.IsSuccessStatusCode)
			{
				responseContent = await response.Content.ReadAsStringAsync();
				taxes(JsonConvert.DeserializeObject(responseContent));
				return responseContent;
			}
			else
			{
				responseContent = await response.Content.ReadAsStringAsync();
				string errorMessage = $"API request failed with status code {response.StatusCode}. Reason: {response.ReasonPhrase}. Response content: {responseContent}";
				MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		async Task send_prompt()
		{
			if(!checkInputs())
				return;

			string response = await GetResponse(promptbox.Text, "-");
			if(response == null)
				return;

			// Parse JSON response
			try
			{
				dynamic jsonResponse = JsonConvert.DeserializeObject(response);
				if(checkResponse(jsonResponse))
				{
					string messageContent = jsonResponse.choices[0].message.content;
					resultbox.Text = messageContent;
				}
			}
			catch(JsonException ex)
			{
				string errorMessage = "Failed to parse JSON response: " + ex.Message;
				MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}

		bool checkResponse(dynamic response)
		{
			if(response.choices == null || response.choices.Count == 0)
			{
				string errorMessage = "API response did not contain any choices.";
				MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			// Check if the first choice contains a message
			if(response.choices[0].message == null || response.choices[0].message.content == null)
			{
				string errorMessage = "API response did not contain a valid message.";
				MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private async void send_prompt_click(object sender, EventArgs e)
		{
			await send_prompt();
		}

		private void apibox_TextChanged(object sender, EventArgs e)
		{
			apibox.PasswordChar = '*';
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/Cranot");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// detect default font family and set it to fontfamilybox if its empty
			if(familybox.Text == "")
			{
				familybox.Text = resultbox.Font.FontFamily.Name;
			}
			else
			{
				// check if the font family is valid
				try
				{
					FontFamily ff = new FontFamily(familybox.Text);
					resultbox.Font = new Font(ff, resultbox.Font.Size);
					promptbox.Font = new Font(ff, promptbox.Font.Size);
					apibox.Font = new Font(ff, apibox.Font.Size);
					resultbox.Font = new Font(ff, resultbox.Font.Size);
					familybox.Font = new Font(ff, familybox.Font.Size);
					screenbox.Font = new Font(ff, screenbox.Font.Size);
				}
				catch
				{
					MessageBox.Show("Invalid font family", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			// fontbox store only the size of the font
			if(fontbox.Text == "")
			{
				// we must get the current font size
				fontbox.Text = resultbox.Font.Size.ToString();
			}
			else
			{
				// we must change the font size of all the textboxes
				// set all fonts to a more good looking font
				FontFamily fontFamily = new FontFamily("Verdana");
				float size = float.Parse(fontbox.Text);
				var newfontsize = new Font(fontFamily, size);
				resultbox.Font = newfontsize;
				promptbox.Font = newfontsize;
				apibox.Font = newfontsize;
				mysterylistbox.Font = newfontsize;
				screenbox.Font = newfontsize;
			}
		}

		async Task magic()
		{
			if(!checkInputs())
				return;

			string prompt = cleanprompt(promptbox.Text);
			
			prompt = $"From '{prompt}', create 10 distinct hyphenated prompts that offer valuable information or insights. No need for categories - the prompts should be diverse and relevant to the text.";
			string response = await GetResponse(prompt, "-");
			if(response == null)
				return;

			//{ "role": "system", "content": "You're a smart prompt suggestion assistant."}
			//content = $"Based on the text '{prompt}', please generate four comprehensive lists with descriptive titles, each consisting of five prompts that start with a hyphen (-). We aim to obtain three distinct categories, each containing five useful prompts related to the text provided. Please ensure that the prompts are informative, relevant, and helpful in understanding the given text."
			//content = $"Provide me 4 thorough named lists of different topics with each list having 5 helpful prompts, each item starts with \"-\", based on the following text: {prompt}"
			//Generate 3 lists of 5 informative prompts that start with a hyphen (-) based on the given text '{prompt}', organized into distinct categories for clarity.The prompts should be relevant and help in understanding the text.
			//content = $"Generate 3 lists of 5 informative prompts that start with a hyphen (-) based on the given text '{prompt}', organized into distinct categories for clarity.The prompts should be relevant and help in understanding the text."


			// Parse JSON response
			try
			{
				dynamic jsonResponse = JsonConvert.DeserializeObject(response);

				if(checkResponse(jsonResponse))
				{
					string messageContent = jsonResponse.choices[0].message.content;
					//screenbox.Text = messageContent;
					string[] items = messageContent.Split(new string[] { " - ", "\n" }, StringSplitOptions.RemoveEmptyEntries);

					foreach(string item in items)
					{
						// perform any necessary processing on each item
						string processedItem = item.Trim();

						// add each item to the ListBox
						mysterylistbox.Items.Add(processedItem);
					}
					runbutton.Visible = true;
				}
			}
			catch(JsonException ex)
			{
				string errorMessage = "Failed to parse JSON response: " + ex.Message;
				MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void chatapiapp_Load(object sender, EventArgs e)
		{
			// set fontbox to the current font size
			fontbox.Text = resultbox.Font.Size.ToString();
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			await magic();

		}

		private async void runbutton_Click(object sender, EventArgs e)
		{
			await runthis();
		}

		async Task dothis(string cmd)
		{
			if(!checkInputs())
				return;
			string prompt = cleanprompt(promptbox.Text);
			string content = $"{cmd} : {prompt}";

			string response = await GetResponse(content, "");
			if(response == null)
				return;

			// Parse JSON response
			try
			{
				dynamic jsonResponse = JsonConvert.DeserializeObject(response);
				if(checkResponse(jsonResponse))
				{
					string messageContent = jsonResponse.choices[0].message.content;
					resultbox.Text = messageContent;
				}
			}
			catch(JsonException ex)
			{
				string errorMessage = "Failed to parse JSON response: " + ex.Message;
				MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		async Task runthis()
		{
			if(!checkInputs())
				return;
			string prompt = cleanprompt(promptbox.Text);
			string cmd = mysterylistbox.SelectedItem.ToString();
			string content = $"{cmd} based on the following text: {prompt}";

			string response = await GetResponse(content, "");
			if(response == null)
				return;

			// Parse JSON response
			try
			{
				dynamic jsonResponse = JsonConvert.DeserializeObject(response);
				if(checkResponse(jsonResponse))
				{
					string messageContent = jsonResponse.choices[0].message.content;
					screenbox.Text = messageContent;
				}
			}
			catch(JsonException ex)
			{
				string errorMessage = "Failed to parse JSON response: " + ex.Message;
				MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.buymeacoffee.com/dimitrismitsos");
		}

		private async void button1_Click_1(object sender, EventArgs e)
		{
			string cmd = comboBox1.SelectedItem.ToString();
			await dothis(cmd);
		}
	}
}