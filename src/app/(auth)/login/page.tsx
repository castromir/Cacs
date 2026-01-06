import { LoginForm } from "./form";

export default function LoginPage() {
  return (
    <div className="h-screen w-screen flex items-center justify-center bg-slate-100">
      <div className="shadow-xl px-8 p-4 bg-white rounded">
        <h1 className="font-semibold text-4xl text-center py-8">Login</h1>
        <LoginForm/>
      </div>
    </div>
  );
}
