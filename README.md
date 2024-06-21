## Google Forms Clone Project

### Overview
This task replicates the basic functionality of Google Forms using a Windows Desktop Application built in Visual Basic and a backend server built with TypeScript and Express. The application allows users to create new submissions, view previous submissions, and navigate through them. The backend server handles storing and retrieving submission data.

### Requirements
- **Frontend**: Visual Studio with support for Visual Basic
- **Backend**: Node.js, TypeScript, Express

### Getting Started

#### Backend Setup

1. **Install Node.js**:
   - Download and install Node.js from the [official website](https://nodejs.org/).

2. **Clone the Repository**:
   - Clone the backend repository from GitHub:
     ```bash
     git clone <your-backend-repo-url>
    
     ```

3. **Install Dependencies**:
   - Navigate to the backend directory and install the required dependencies:
     ```bash
     npm install
     ```

4. **Run the Backend Server**:
   - Start the backend server using the following command:
     ```bash
     npm start
     ```
   - The server will run on `http://localhost:3000`.

#### Frontend Setup

1. **Clone the Repository**:
   - Clone the frontend repository from GitHub:
     ```bash
     git clone <your-frontend-repo-url>
    
     ```

2. **Open the Project**:
   - Open the project in Visual Studio.

3. **Build and Run the Application**:
   - Build the solution and run the application from Visual Studio.

### Frontend Features

1. **Main Form**:
   - Contains two buttons: "View Submissions" and "Create New Submission".
   - Keyboard shortcuts:
     - Ctrl+V: Opens the View Submissions form.
     - Ctrl+N: Opens the Create New Submission form.

2. **View Submissions Form**:
   - Displays submitted forms.
   - Contains two buttons: "Previous" and "Next" to navigate through submissions.

3. **Create Submission Form**:
   - Contains editable fields for Name, Email, Phone Number, and GitHub repo link.
   - Includes a stopwatch with start/stop functionality.
   - A submit button to send the submission data to the backend.
   - Keyboard shortcut:
     - Ctrl+S: Submits the form.

### Backend API Endpoints

1. **/ping**:
   - **GET** request that returns `true`.
   - Use this to check if the server is running.

2. **/submit**:
   - **POST** request to submit a new form entry.
   - Parameters: `name`, `email`, `phone`, `github_link`, `stopwatch_time`.
   - Example:
     ```json
     {
       "name": "John Doe",
       "email": "john.doe@example.com",
       "phone": "123-456-7890",
       "github_link": "https://github.com/johndoe",
       "stopwatch_time": "00:02:15"
     }
     ```

3. **/read**:
   - **GET** request to retrieve a form submission by index.
   - Query parameter: `index` (0-indexed).
   - Example: `http://localhost:3000/read?index=0`

### Database Structure
The backend uses a JSON file (`db.json`) to store submissions. The structure is as follows:
```json
{
  "submissions": [
    {
      "name": "John Doe",
      "email": "john.doe@example.com",
      "phone": "123-456-7890",
      "github_link": "https://github.com/johndoe",
      "stopwatch_time": "00:02:15"
    }
  ]
}
```


### License
This project is licensed under the MIT License. 

