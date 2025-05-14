def process_user_data(data):
    users = []
    
    for i in range(len(data)):
        user = {
            "id": data[i]["id"],
            "name": data[i]["name"],
            "email": data[i]["email"],
            "active": True if data[i]["status"] == "active" else False
        }
        users.append(user)
    
    print("Processed " + str(len(users)) + " users")
    
    return users

def save_to_database(users):
    # TODO: Implement database connection
    success = True
    return success
