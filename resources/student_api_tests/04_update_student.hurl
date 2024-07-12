# Test PUT (update) a student
PUT http://localhost:8080/api/Student/{{student_id}}
{
    "id": {{student_id}},
    "name": "John Updated",
    "email": "john.updated@example.com",
    "dateOfBirth": "2000-01-01",
    "gpa": 3.7
}
HTTP 204

# Verify the update
GET http://localhost:8080/api/Student/{{student_id}}
HTTP 200
[Asserts]
jsonpath "$.name" == "John Updated"
jsonpath "$.email" == "john.updated@example.com"
jsonpath "$.gpa" == 3.7
