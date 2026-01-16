import { z } from "zod";

const passwordValidation =
  /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+}{":;'?/.,<>])[A-Za-z\d!@#$%^&*()_+}{":;'?/.,<>]{6,10}$/;

export const registerSchema = z.object({
  email: z.email(),
  password: z.string().regex(passwordValidation, {
    message:
      "Password must contain 1 lowercase character, 1 uppercase character, 1 number, 1 special character and be 6-10 characters",
  }),
});

export type RegisterSchema = z.infer<typeof registerSchema>;
