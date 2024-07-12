# Test GET a specific student
GET http://localhost:8080/api/Student/{{student_id}}
HTTP 200
[Asserts]
jsonpath "$.name" == "John Doe"
jsonpath "$.email" == "john.doe@example.com"
