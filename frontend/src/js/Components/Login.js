export default function Login() {
    return `
    <div class="loginpage">
        <div class="form">
            <form class="login-form">
            <input name="username" type="text" placeholder="username" />
            <input name="password" type="text" placeholder="password" />
            <button id="logbtn">Login</button>
            <p class"message"> Not Registered? <button id="registerbtn">Register</button><p>
        </div>
    </div>

    `
}