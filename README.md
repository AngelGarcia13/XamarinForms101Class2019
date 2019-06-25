# XamarinForms101Class2019
Examples and presentations for the summer course of Xamarin Forms at UASD 2019

🎓 Week 1 https://drive.google.com/open?id=1rEpWhWg2hLpG-AyA6lXXTvGKBDTWCxYpIDITVeOHmNs

🤠 Exercise: 
Create a blank app and add at least 3 controls to the MainPage.

🎓 Week 2 https://drive.google.com/open?id=1TeFYh3ZLC64CT4ESwSRz6grhEGg2mZoOJxvwt2C3ueY

🤠 Exercise:
1. Create a blank Xamarin Forms App, call it FaceFinder.

2. Add the Models, Views and ViewModels folders to the portable project (FaceFinder).

3. Add a new ContentPage called LoginPage (right click on the Views folder, Add => ContentPage).

4. Create a new class called LoginPageViewModel in the ViewModels folder, add all the UI Logic 
   here (Properties and Commands) using the INotifyPropertyChanged.

5. Create the UI for the LoginPage.xaml (see the image for reference) and add the Bindings.

=========== App Requirements ============
When the user taps on the Sing In button, you have to validate that the 
credentials are correct (use name@mail.com as username and admin123 as password).

In the validation command method, if the credentials are valid, you have to wait 3 seconds 
and then move the user to another page using the following code:
await Application.Current.MainPage.Navigation.PushAsync(new MainPage());.

In the case that the user put wrong credentials, you have to show an alert telling the user
that his/her username or password are incorrect.

🎓 Week 3 https://docs.google.com/presentation/d/1HisoyLS5lkrzBKBL2kJcQH19YBkk1Lyi1MTjniZ7L4o

🤠 Exercise:
- Create a blank app and add the MVVM structure.
- Add Navigation for the MainPage.
- Create a ListView with a collection of people wanted by the FBI:
	~ Use a Model like PersonWanted with the properties Name, NickName, Age, WantedReasons and PictureUrl
	~ Use an ImgeCell to render the Items in the ListView.
	~ The WantedReasons are not shown in the list.
- When we select an item from the list, navigate to a details page (let's call it DetailsPage).
- In the DetailsPage put all the details of the PeopleWanted including the WantedReasons.
- Add a button to "Send an alert" to the FBI, when the command of this button gets triggered, wait 3 seconds and show an alert dialog saying: "We have sent the alert for TheNameOfTheSelectedPerson", while we wait those seconds the button should be disabled and an ActivityIndicator should be displayed above the button.
