import { NextResponse } from 'next/server'
import { createClient } from '@/src/lib/supabase/server'

export async function GET(request: Request) {
  const { searchParams, origin } = new URL(request.url)
  const code = searchParams.get('code')

  if (!code) {
    return NextResponse.redirect(`${origin}/login`)
  }

  const supabase = await createClient()

  await supabase.auth.exchangeCodeForSession(code)

  const {
    data: { user },
  } = await supabase.auth.getUser()

  const { data: allowedUser } = await supabase
    .from('allowed_users')
    .select('*')
    .eq('email', user?.email)
    .single()

  if (!allowedUser) {
    await supabase.auth.signOut()
    return NextResponse.redirect(`${origin}/unauthorized`)
  }

  return NextResponse.redirect(`${origin}/ficha`)
}
