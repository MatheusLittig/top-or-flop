import React from 'react'

import { Box, Heading, Link, List, ListItem } from '@chakra-ui/react'

import { socialLinks } from './constants'

const SocialBox: React.FC = () => {
  return (
    <Box display="flex" flexDirection="column" alignItems="flex-end">
      <Heading as="h3" fontSize="md" fontWeight="700">
        FOLLOW US
      </Heading>

      <List display="flex" alignItems="center" mt={4}>
        {socialLinks.map(link => (
          <ListItem key={link.id} ml={4}>
            <Link href={link.href} alt={link.alt}>
              {link.icon}
            </Link>
          </ListItem>
        ))}
      </List>
    </Box>
  )
}

export default SocialBox
