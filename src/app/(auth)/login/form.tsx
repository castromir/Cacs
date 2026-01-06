'use client'

export const LoginForm = () => {
    const onSubmit = (e: React.FormEvent) => {
        e.preventDefault();
        console.log('Login!');
    }
    return (
        <form>  
            <input/>
            <input/>
            <button>Login</button>
        </form>
    )
}