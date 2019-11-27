export default function Profile(profile) { 
    return `
        <div id="profile-main">
            <h1>Username: ${profile.userName}</h1>
            <h1>Child's Name: ${profile.childName}</h1>
            <h1>Child's Age: ${profile.childAge}</h1>
        </div>
    `
}