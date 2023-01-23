using Group_Project.Data;
using Group_Project.Models;
using Group_Project.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Group_Project.Services
{
	public class Seed
	{ 
		public void SeedDb(IUnitOfWork _unitOfWork)
		{
			// Candidates
			if (_unitOfWork.Candidate.GetAll().Count() == 0) { 
			var candidate1 = new Candidate
			{
				FirstName = "Bella",
				MiddleName = "Maria",
				LastName = "Lasithiotaki",
				Gender = "Female",
				NativeLanguage = "Greek",
				BirthDate = new DateTime(1990, 01, 12),
				PhotoIdType = "Passport",
				PhotoIdNumber = "AP7812351",
				PhotoIdIssueDate = new DateTime(2005, 05, 22),
				Email = "bella.lasithiotaki@gmail.com",
				Address = "Rodopis 51",
				AddressLine2 = "Street",
				Country = "Greece",
				Region = "Vrilissia",
				City = "Athens",
				PostalCode = 15235,
				LandlineNumber = "210000000",
				MobileNumber = "6900000000"
			};

			var candidate2 = new Candidate
			{
				FirstName = "Vicky",
				MiddleName = "",
				LastName = "Bisbiki",
				Gender = "Female",
				NativeLanguage = "Greek",
				BirthDate = new DateTime(1985, 01, 12),
				PhotoIdType = "Passport",
				PhotoIdNumber = "AP1234567",
				PhotoIdIssueDate = new DateTime(2007, 05, 10),
				Email = "vicky.bisbiki@gmail.com",
				Address = "Rodopis ",
				AddressLine2 = "Street",
				Country = "Greece",
				Region = "Melissia",
				City = "Athens",
				PostalCode = 15233,
				LandlineNumber = "210000000",
				MobileNumber = "6900000000"
			};

			var candidate3 = new Candidate
			{
				FirstName = "Nikolaos",
				MiddleName = "",
				LastName = "Papadatos",
				Gender = "Male",
				NativeLanguage = "Greek",
				BirthDate = new DateTime(1988, 10, 15),
				PhotoIdType = "Passport",
				PhotoIdNumber = "AP1234567",
				PhotoIdIssueDate = new DateTime(2007, 05, 10),
				Email = "nikolaos.papadatos@gmail.com",
				Address = "Pentelis 02",
				AddressLine2 = "Street",
				Country = "Greece",
				Region = "Chalandri",
				City = "Athens",
				PostalCode = 15232,
				LandlineNumber = "210000000",
				MobileNumber = "6900000000"
			};

			var candidate4 = new Candidate
			{
				FirstName = "Ioannis",
				MiddleName = "",
				LastName = "Samartzis",
				Gender = "Male",
				NativeLanguage = "Greek",
				BirthDate = new DateTime(1990, 01, 04),
				PhotoIdType = "Passport",
				PhotoIdNumber = "AP3456789",
				PhotoIdIssueDate = new DateTime(2005, 05, 22),
				Email = "ioannis.samartzis@gmail.com",
				Address = "Dios 12",
				AddressLine2 = "Street",
				Country = "Greece",
				Region = "Penteli",
				City = "Athens",
				PostalCode = 15355,
				LandlineNumber = "210000000",
				MobileNumber = "6900000000"
			};

			var candidate5 = new Candidate
			{
				FirstName = "Neoklis",
				MiddleName = "",
				LastName = "Varsamos",
				Gender = "Male",
				NativeLanguage = "Greek",
				BirthDate = new DateTime(1992, 01, 04),
				PhotoIdType = "Passport",
				PhotoIdNumber = "AP3456789",
				PhotoIdIssueDate = new DateTime(2005, 05, 22),
				Email = "neoklis.varsamos@gmail.com",
				Address = "Kissavou 46",
				AddressLine2 = "Street",
				Country = "Greece",
				Region = "Penteli",
				City = "Athens",
				PostalCode = 15355,
				LandlineNumber = "210000000",
				MobileNumber = "6900000000"
			};

			_unitOfWork.Candidate.Add(candidate1);
			_unitOfWork.Candidate.Add(candidate2);
			_unitOfWork.Candidate.Add(candidate3);
			_unitOfWork.Candidate.Add(candidate4);
			_unitOfWork.Candidate.Add(candidate5);
			_unitOfWork.Save();
			}

			// Certificates
			if (_unitOfWork.Certificate.GetAll().Count() == 0)
			{
				var certificate1 = new Certificate
				{
					Title = "DevOps",
					PossibleMarks = 100

				};

				var certificate2 = new Certificate
				{
					Title = "Python",
					PossibleMarks = 100

				};

				var certificate3 = new Certificate
				{
					Title = "Javascript",
					PossibleMarks = 100

				};

				_unitOfWork.Certificate.Add(certificate1);
				_unitOfWork.Certificate.Add(certificate2);
				_unitOfWork.Certificate.Add(certificate3);
				_unitOfWork.Save();


				// Topic

				var topic1Cert1 = new Topic
				{
					Title = "DevOps Topic 1",
					Description = "This is the first topic for Certificate of DevOps",
					//SubjectWeight = 30,
					Certificate = certificate1
				};
				var topic2Cert1 = new Topic
				{
					Title = "DevOps Topic 2",
					Description = "This is the second topic for Certificate of DevOps",
					//SubjectWeight = 30,
					Certificate = certificate1
				};
				var topic3Cert1 = new Topic
				{
					Title = "DevOps Topic 3",
					Description = "This is the third topic for Certificate of DevOps",
					//SubjectWeight = 40,
					Certificate = certificate1

				};

				_unitOfWork.Topic.Add(topic1Cert1);
				_unitOfWork.Topic.Add(topic2Cert1);
				_unitOfWork.Topic.Add(topic3Cert1);
				_unitOfWork.Save();



				var topic1Cert2 = new Topic
				{
					Title = "Python Topic 1",
					Description = "This is the first topic for Certificate of Python",
					//SubjectWeight = 40,
					Certificate = certificate2
				};
				var topic2Cert2 = new Topic
				{
					Title = "Python Topic 2",
					Description = "This is the second topic for Certificate of Python",
					//SubjectWeight = 30,
					Certificate = certificate2
				};
				var topic3Cert2 = new Topic
				{
					Title = "Python Topic 3",
					Description = "This is the third topic for Certificate of Python",
					//SubjectWeight = 30,
					Certificate = certificate2
				};

				_unitOfWork.Topic.Add(topic1Cert2);
				_unitOfWork.Topic.Add(topic2Cert2);
				_unitOfWork.Topic.Add(topic3Cert2);
				_unitOfWork.Save();



				var topic1Cert3 = new Topic
				{
					Title = "Javascript Topic 1",
					Description = "This is the first topic for Certificate of Javascript",
					//SubjectWeight = 40,
					Certificate = certificate3
				};
				var topic2Cert3 = new Topic
				{
					Title = "Javascript Topic 2",
					Description = "This is the second topic for Certificate of Javascript",
					//SubjectWeight = 35,
					Certificate = certificate3
				};
				var topic3Cert3 = new Topic
				{
					Title = "Javascript Topic 3",
					Description = "This is the third topic for Certificate of Javascript",
					//SubjectWeight = 25,
					Certificate = certificate3
				};

				_unitOfWork.Topic.Add(topic1Cert3);
				_unitOfWork.Topic.Add(topic2Cert3);
				_unitOfWork.Topic.Add(topic3Cert3);
				_unitOfWork.Save();
			}
			if (_unitOfWork.QuestionAnswers.GetAll().Count() == 0)
			{ 
				var topics = _unitOfWork.Topic.GetAll();
				foreach (var topic in topics)
				{
					for (int i = 1; i < 4; i++)
					{

                        QuestionAnswers q = new QuestionAnswers
                        {
                            // Possible answersPython

                            Answer1 = "This is a generic answer to a question called A1",
							Answer2 = "This is a generic answer to a question called A2",
							Answer3 = "This is a generic answer to a question called A3",
							Answer4 = "This is a generic answer to a question called A4",
							CorrectIndex = new Random().Next(1, 4),


						// Question

							TextOfQuestion = $"This is an example of a Question with Number: {i}",
							Topics = topic,

						};
						_unitOfWork.QuestionAnswers.Add(q);
						_unitOfWork.Save();
					}
				}

			}
            if (_unitOfWork.QuestionAnswers.GetAll().Count() == 0)
            {
                var topics = _unitOfWork.Topic.GetAll();
                foreach (var topic in topics)
                {
                    for (int i = 1; i < 4; i++)
                    {
						QuestionAnswers q = new QuestionAnswers
						{
							// Possible answersPython

							Answer1 = "This is a generic answer to a question called A1",
							Answer2 = "This is a generic answer to a question called A2",
							Answer3 = "This is a generic answer to a question called A3",
							Answer4 = "This is a generic answer to a question called A4",
							CorrectIndex = new Random().Next(1, 4),


                        // Question


                            TextOfQuestion = $"This is an example of a Question with Number: {i}",
                            Topics = topic,
                        };
                        _unitOfWork.QuestionAnswers.Add(q);
                        _unitOfWork.Save();
                    }
                }

            }
        }
	}
}
