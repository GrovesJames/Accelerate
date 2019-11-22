export default function Register() {
    return `
    <div class="loginpage">
        <div class="form">
            <form class="register-form">
            <input type="text" placeholder="username" />
            <input type="text" placeholder="password" />
            <input type="text" placeholder="email" />
            <button>Create</button>
            <p class"message">Already Registered? <button>Login</button></p>
            </form>
        </div>
    </div>
    `
}