# Test POST a new student
POST http://localhost:8080/api/Student
{
    "name": "John Doe",
    "email": "john.doe@example.com",
    "dateOfBirth": "2000-01-01",
    "gpa": 3.5
}
HTTP 201
[Captures]
student_id: jsonpath "$.id"
