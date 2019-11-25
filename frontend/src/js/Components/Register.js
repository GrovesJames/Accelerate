export default function Register() {
    return `
    <div class="loginpage">
        <div class="form">
            <form class="register-form">
            <input type="text" placeholder="username" />
            <input type="text" placeholder="password" />
            <button id="createbtn">Create</button>
            <p class"message">Already Registered? <button id="btn2">Login</button></p>
            </form>
        </div>
    </div>
    `
}