# Central Physician Appointment System Application

This is a comprehensive application designed to streamline the process of managing patient appointments, prescriptions, and medications. The system has a user-friendly interface with three distinct user roles: **Secretary**, **Pharmacist**, and **Doctor**. Each role has specific functionalities that allow for efficient management of patient data, appointments, prescriptions, and medications.And was created during my second year of university.

## Features

### Secretary Role

- **Patient Registration**:
  - The secretary can add a new patient by filling in relevant details, such as personal information, medical history, and other essential data.
  - This is similar to scheduling an appointment for the patient.

- **View and Manage Patients**:
  - The secretary can view all registered patients in the system.
  - Options to go back to the patient registration screen and add more patients are available.

### Pharmacist Role

- **Add Medication**:
  - The pharmacist can add new medications to the system by entering details such as the medication barcode, name, dosage, and other related information.
  
- **View Medication Records**:
  - The pharmacist can view all registered medications in the system, manage stock levels, and access the medication information at any time.

### Doctor Role

- **Add Patient Examination Information**:
  - The doctor can input examination details for patients, including the diagnosis and any relevant notes.
  
- **Prescription Writing**:
  - The doctor can create prescriptions for patients by selecting the appropriate medications and entering the dosage and other necessary instructions.

- **Examination Listing**:
  - The doctor can view a list of all the patient examinations they have conducted.

### Prescription Creation

- **Generate Prescription**:
  - The doctor can create and print prescriptions for patients.
  - The prescription includes details about the medications, dosage instructions, and additional recommendations for the patient.

## Technologies Used

- **C#:** The application was developed using C# with Windows Forms for a simple and efficient desktop-based interface.
- **PostgreSQL:** The application uses PostgreSQL as the backend database to store patient records, medications, and prescriptions.

## How It Works

1. **Login Screen**:
   - Each user (Secretary, Pharmacist, Doctor) has different access rights.
   - The login screen directs users to the appropriate dashboard based on their role.

2. **Secretary Dashboard**:
   - The secretary can register patients and view a list of existing patients.
   - The secretary can navigate back and forth between different screens for patient management.

3. **Pharmacist Dashboard**:
   - The pharmacist can manage medications by adding new ones and viewing existing records.
   - They can navigate easily between the medication management screens.

4. **Doctor Dashboard**:
   - The doctor can add examination details for patients, access the list of all examinations, and create prescriptions.
   - The doctor has access to a prescription-writing interface where medications can be selected and dosage information can be provided.

5. **Prescription Management**:
   - The doctor can generate and print prescriptions for patients, which include all the necessary medication details.

## How to Run

1. Install **PostgreSQL** and set up the required database schema.
2. Configure the application with the database connection string in the `appsettings.json` or configuration file.
3. Open the project in your preferred C# IDE (e.g., Visual Studio).
4. Build and run the application.
5. Log in as a Secretary, Pharmacist, or Doctor to start using the system.

## Future Improvements

- Implement role-based access control with enhanced security.
- Integrate an appointment scheduling system to further streamline the workflow.
- Add an analytics dashboard for better management of medications, patient appointments, and prescriptions.

## License

This project is free to use and modify for educational purposes. Contributions are welcome!
