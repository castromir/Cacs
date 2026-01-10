import { redirect } from "next/navigation";

export default function HomePage() {
    redirect('/login')
}

/*import Link from "next/link";
import { redirect } from "next/navigation";

export default function HomePage() {
  return (
    <h1>
        Welcome to the Home Page
        <Link 
        href="/login"
        className="px-4 py-2 rounded bg-blue-500 text-white ml-4"
        >
            Login
        </Link>
    </h1>
  );
} */

