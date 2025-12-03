using EFdb.Data;
using EFdb.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

// Добавление данных
Console.WriteLine("Добавляем отделение, врача и пациента");

var cardiology = new Department { Name = "Кардиология" };
context.Departments.Add(cardiology);

var doctor = new Doctor
{
    FirstName = "Иван",
    LastName = "Петров",
    Specialization = "Кардиолог",
    Department = cardiology
};
context.Doctors.Add(doctor);

var patient = new Patient
{
    FirstName = "Анна",
    LastName = "Сидорова",
    DateOfBirth = new DateTime(2000, 1, 1),
    Phone = "+1234567890"
};
context.Patients.Add(patient);

context.SaveChanges();

// create
Console.WriteLine("Создаём запись на приём");
var appointment = new Appointment
{
    ScheduledAt = DateTime.Now.AddDays(2),
    PatientId = patient.Id,
    DoctorId = doctor.Id
};
context.Appointments.Add(appointment);
context.SaveChanges();

// get
Console.WriteLine("\n Все пациенты:");
foreach (var p in context.Patients)
{
    Console.WriteLine($"-{p.FirstName} {p.LastName}, телефон: {p.Phone}");
}

// update
Console.WriteLine("\nОбновляем телефон пациента");
patient.Phone = "+0987654321";
context.SaveChanges();
Console.WriteLine($"Новый телефон: {patient.Phone}");

// Создание истории болезни и рецепта
Console.WriteLine("\nДобавляем историю болезни и рецепт");
var record = new MedicalRecord
{
    Diagnosis = "ОРВИ",
    Notes = "Рекомендовано наблюдение",
    PatientId = patient.Id,
    AppointmentId = appointment.Id
};
context.MedicalRecords.Add(record);
context.SaveChanges();

var prescription = new Prescription
{
    Medication = "Ибуфен",
    Dosage = "200 мг",
    Quantity = 20,
    AppointmentId = appointment.Id,
    MedicalRecordId = record.Id
};
context.Prescriptions.Add(prescription);
context.SaveChanges();

// Чтение с включением связей
Console.WriteLine("\nПриём с рецептом:");
var fullAppointment = context.Appointments
    .Include(a => a.Patient)
    .Include(a => a.Doctor)
    .Include(a => a.Prescriptions)
    .First(a => a.Id == appointment.Id);

Console.WriteLine($"Пациент: {fullAppointment.Patient.FirstName} у доктора {fullAppointment.Doctor.LastName}");
foreach (var pr in fullAppointment.Prescriptions)
{
    Console.WriteLine($"-Рецепт: {pr.Medication}, {pr.Dosage}, {pr.Quantity} шт");
}

// delete
Console.WriteLine("\nУдаляем рецепт...");
context.Prescriptions.Remove(prescription);
context.SaveChanges();
Console.WriteLine("Рецепт удалён.");

var count = context.Prescriptions.Count();
Console.WriteLine($"Осталось рецептов: {count}");