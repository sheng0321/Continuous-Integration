# CVGS Insiders Club

## Purpose
The CVGS Insiders Club is an online platform designed to increase online game sales by providing exclusive "members only" features. This project aims to attract and retain customers by offering a variety of features such as game reviews, wish lists, event registrations, and more.

## Features
### Admin Panel
- Add, edit, and delete games
- Enter event data for upcoming events
- View and print various reports (game list, game detail, member list, member detail, wish list, sales)
- Review and approve game reviews

### Member Features
- **Joining and Logging in:**
  - Unique display name, email address, strong password, and captcha validation
  - Email account validation
  - Limit consecutive login attempts to 3
  - Password reset via email
- **Profile Management:**
  - Update actual name, gender, birth date
  - Opt-in for promotional emails
- **Preferences:**
  - Indicate favorite platforms and game categories
- **Address Management:**
  - Enter, modify, and delete mailing and shipping addresses
  - Indicate if mailing and shipping addresses are the same
- **Credit Cards:**
  - Register one or more valid credit cards
- **Game Selection:**
  - Search for games, select from a list, and view game details
- **Wish List:**
  - Create and manage a wish list
  - Share wish list with friends, family, and on social media
- **Friends and Family:**
  - Add members to the Friends and Family list
- **Game Ratings and Reviews:**
  - Rate games and view overall ratings
  - Write reviews (subject to moderator approval)
- **Cart and Checkout:**
  - Add games to cart and checkout using registered credit cards
  - Save order information and update order status to "Processed"
- **Downloads:**
  - Download free or purchased digital games
- **Events:**
  - Register for upcoming events

## Technical Requirements
- **Backend:** ASP.NET Core 8 API
- **Frontend:** React.js
- **Database:** Microsoft SQL Server (using existing CVGS database or a new one)

## Building and Running the Project
### Prerequisites
- .NET Core SDK
- Node.js and npm
- SQL Server

### Setup Instructions
1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/cvgs-insiders-club.git
   cd cvgs-insiders-club
   ```
2. **Backend Setup:**

Navigate to the backend project directory:
   ```bash
cd backend
Restore the .NET dependencies:
dotnet restore
Update the database connection string in appsettings.json.
Run the backend server:
dotnet run
```
3. **Frontend Setup:**

Navigate to the frontend project directory:
   ```bash
cd ../frontend
Install the npm dependencies:
npm install
Start the React development server:
npm start
```
4. **Access the Application:**

Open your browser and navigate to http://localhost:3000 for the frontend.
The backend API will be running on http://localhost:5000.
## License
This project is licensed under the MIT License. I chose this license because it is permissive and allows others to freely use, modify, and distribute the software, which encourages collaboration and sharing within the developer community.