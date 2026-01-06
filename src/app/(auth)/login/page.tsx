import { LoginForm } from "./form";

export default function Login() {
  return (
    <div className="h-screen w-screen flex items-center justify-center bg-slate-100">
      <div className="shadow-xl p-4 bg-white rounded">
        <h1>Login</h1>
        <LoginForm/>
      </div>
    </div>
  );
}
