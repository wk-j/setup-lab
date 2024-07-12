# Test DELETE a student
DELETE http://localhost:8080/api/Student/{{student_id}}
HTTP 204

# Verify the deletion
GET http://localhost:8080/api/Student/{{student_id}}
HTTP 404
